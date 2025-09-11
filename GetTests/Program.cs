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


            //TestResults results = new TestResults();

            //results = DeserializeReport(xmlFilePath);


            ;
            //XmlRootAttribute xRoot = new XmlRootAttribute();
            //xRoot.ElementName = "test-run";
            //xRoot.IsNullable = false;
            //;
            //XmlNUnit xmlNUnit = new XmlNUnit();


            //XmlSerializer serializer = new XmlSerializer(typeof(XmlNUnit), xRoot);

            //using (FileStream fileStream = new FileStream(xmlFilePath, FileMode.Open))
            //{
            //    xmlNUnit = (XmlNUnit) serializer.Deserialize(fileStream);
            //}

            XDocument doc = XDocument.Load(xmlFilePath);

            // Example: Get all test case names
            var testCaseNames = doc.Descendants("test-suite").Where(ts => ts.Attribute("type")?.Value == "ParameterizedMethod")
                                   .ToList();
            ;
            testCaseNames.AddRange(doc.Descendants("test-case").Where(ts => ts.Attribute("name")?.Value == ts.Attribute("methodname")?.Value)
                                   .ToList());


            foreach (var testCase in testCaseNames)
            {
                var proper = testCase.Descendants("property").ToList();

                string name = "";
                string TestCaseId = "";

                foreach (var item in proper)
                {
                    if (item.Attribute("name")?.Value == "Name")
                    {
                        name = item.Attribute("value")?.Value;
                    }

                    if (item.Attribute("name")?.Value == "TestCaseId")
                    {
                        TestCaseId = item.Attribute("value")?.Value;
                    }
                }


                Console.WriteLine($"{TestCaseId} \t {name}");
            }


            //foreach (var testCase in testCaseNames.Skip(3))
            //{
            //    Console.WriteLine($"{testCase.Attribute("name")?.Value} ({testCase.Attribute("testcasecount")?.Value})");

            //    var test_fixture = testCase.Descendants("test-suite").Where(ts => ts.Attribute("type")?.Value == "TestFixture")
            //                       .ToList(); //


            //    foreach (var tf in test_fixture)
            //    {
            //        Console.WriteLine($"\t{tf.Attribute("name")?.Value} ");

            //    }



            //}



            ;
        }

        public static TestResults DeserializeReport(string xmlFilePath)
        {

            XmlRootAttribute xRoot = new XmlRootAttribute();
            xRoot.ElementName = "test-run";
            xRoot.IsNullable = false;

            XmlSerializer serializer = new XmlSerializer(typeof(TestResults), xRoot);
            using (FileStream fileStream = new FileStream(xmlFilePath, FileMode.Open))
            {
                return (TestResults)serializer.Deserialize(fileStream);
            }
        }





        // Define classes mirroring the NUnit XML structure
        [XmlRoot("test-run")]
        public class TestResults
        {
            [XmlAttribute("name")]
            public string? Name { get; set; }

            [XmlElement("test-suite")]
            public List<TestSuite> TestSuites { get; set; } = new();
        }

        public class TestSuite
        {
            [XmlAttribute("name")]
            public string? Name { get; set; }

            [XmlAttribute("result")]
            public string? Result { get; set; }

            [XmlElement("results")]
            public TestSuiteResults Results { get; set; } = new();

            [XmlElement("test-suite")]
            public List<TestSuite> TestSuites { get; set; } = new();
        }

        public class TestSuiteResults
        {
            [XmlElement("test-case")]
            public List<TestCase> TestCases { get; set; } = new();
        }

        public class TestCase
        {
            [XmlAttribute("name")]
            public string? Name { get; set; }

            [XmlAttribute("result")]
            public string? Result { get; set; }
        }
    }
}
