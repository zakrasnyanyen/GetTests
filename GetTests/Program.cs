using System.Xml.Linq;
using System.Xml.Serialization;
using static GetTests.Program;

namespace GetTests
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string xmlFilePath = @"C:\Users\ZEN\SpdsTest\net8.0\finded_test.xml";
            //PullAllTestCases(xmlFilePath);

            XDocument doc = XDocument.Load(xmlFilePath);
            var testCaseNames = doc.Descendants("test-suite").Where(ts => ts.Attribute("type")?.Value == "TestSuite")
                                   .ToList();


            foreach (var testCase in testCaseNames.Skip(3))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"{testCase.Attribute("name")?.Value} ({testCase.Attribute("testcasecount")?.Value})");

                var test_fixture = testCase.Descendants("test-suite").Where(ts => ts.Attribute("type")?.Value == "TestFixture")
                                   .ToList(); //


                foreach (var tf in test_fixture)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine($"\t{tf.Attribute("name")?.Value} ({tf.Attribute("testcasecount")?.Value})");

                    var xml_report = tf.Descendants("test-suite").Where(ts => ts.Attribute("type")?.Value == "ParameterizedMethod")
                                   .ToList();
                    xml_report.AddRange(tf.Descendants("test-case").Where(ts => ts.Attribute("name")?.Value == ts.Attribute("methodname")?.Value)
                                   .ToList());

                    foreach (var item in GetTests(xml_report))
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine($"\t\t{item.Name} ");
                    }

                }
            }
            ;
        }

        private static List<Test_case> PullAllTestCases(string xmlFilePath)
        {
            XDocument doc = XDocument.Load(xmlFilePath);

            var xml_report = doc.Descendants("test-suite").Where(ts => ts.Attribute("type")?.Value == "ParameterizedMethod")
                                   .ToList();
            xml_report.AddRange(doc.Descendants("test-case").Where(ts => ts.Attribute("name")?.Value == ts.Attribute("methodname")?.Value)
                                   .ToList());

            List<Test_case> cases = GetTests(xml_report);
            cases.Sort((x, y) => x.Property.TestCaseId.CompareTo(y.Property.TestCaseId));

            return cases;
        }

        private static List<Test_case> GetTests(List<XElement> xml_report)
        {
            List<Test_case> cases = new List<Test_case>();

            foreach (var testCase in xml_report)
            {
                var prop = GetProperty(testCase);

                var temp = new Test_case()
                {
                    methodname = testCase.Attribute("methodname")?.Value,
                    classname = testCase.Attribute("classname")?.Value,
                    runstate = testCase.Attribute("runstate")?.Value,
                    fullname = testCase.Attribute("fullname")?.Value,
                    Name = testCase.Attribute("name")?.Value,
                    Property = prop,
                };

                if (testCase.Attribute("type")?.Value == "ParameterizedMethod")
                {
                    temp.IsParameterizedMethod = true;

                    var nested_xml_tc = testCase.Descendants("test-case").ToList();
                    temp.NestedParamTests = GetTests(nested_xml_tc);
                }

                cases.Add(temp);
                //Console.WriteLine($"{prop.TestCaseId} \t {prop.Name}");
            }
            return cases;
        }
        private static Property GetProperty(XElement testCase)
        {
            var proper = testCase.Descendants("property").ToList();

            Property property = new();

            foreach (var item in proper)
            {
                if (item.Attribute("name")?.Value == "Name")
                {
                    property.Name = item.Attribute("value")?.Value;
                }
                if (item.Attribute("name")?.Value == "TestCaseId")
                {
                    property.TestCaseId = item.Attribute("value")?.Value;
                }
                if (item.Attribute("name")?.Value == "GUID")
                {
                    property.Guid = item.Attribute("value")?.Value;
                }
                if (item.Attribute("name")?.Value == "Steps")
                {
                    property.Steps = item.Attribute("value")?.Value;
                }
                if (item.Attribute("name")?.Value == "Author")
                {
                    property.Author = item.Attribute("value")?.Value;
                }
                if (item.Attribute("name")?.Value == "CreateDate")
                {
                    property.CreateDate = item.Attribute("value")?.Value;
                }


            }

            return property;
        }
        public class Test_case
        {
            public bool IsParameterizedMethod { get; set; } = false;
            public string Name { get; set; } = "";
            public string methodname { get; set; } = "";
            public string fullname { get; set; } = "";
            public string classname { get; set; } = "";
            public string runstate { get; set; } = "";


            public Property Property { get; set; } = new Property();
            public List<Test_case> NestedParamTests { get; set; } = new();
        }

        public class Property
        {
            public string Name { get; set; } = string.Empty;
            public string TestCaseId { get; set; } = string.Empty;
            public string Guid { get; set; } = string.Empty;
            public string Steps { get; set; } = string.Empty;

            public string Author { get; set; } = string.Empty;
            public string CreateDate { get; set; } = string.Empty;
        }
    }
}
