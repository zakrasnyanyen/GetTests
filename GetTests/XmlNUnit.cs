using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetTests
{
    public class XmlNUnit
    {

        // Примечание. Для запуска созданного кода может потребоваться NET Framework версии 4.5 или более поздней версии и .NET Core или Standard версии 2.0 или более поздней.
        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        [System.Xml.Serialization.XmlRootAttribute("test-run", Namespace = "", IsNullable = false)]
        public partial class testrun
        {

            public testrunTestsuite testsuiteField;

            public byte idField;

            public string runstateField;

            public ushort testcasecountField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("test-suite")]
            public testrunTestsuite testsuite
            {
                get
                {
                    return this.testsuiteField;
                }
                set
                {
                    this.testsuiteField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte id
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string runstate
            {
                get
                {
                    return this.runstateField;
                }
                set
                {
                    this.runstateField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public ushort testcasecount
            {
                get
                {
                    return this.testcasecountField;
                }
                set
                {
                    this.testcasecountField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class testrunTestsuite
        {

            public testrunTestsuiteEnvironment environmentField;

            public testrunTestsuiteSetting[] settingsField;

            public testrunTestsuiteProperty[] propertiesField;

            public testrunTestsuiteTestsuite testsuiteField;

            public string typeField;

            public string idField;

            public string nameField;

            public string fullnameField;

            public string runstateField;

            public ushort testcasecountField;

            /// <remarks/>
            public testrunTestsuiteEnvironment environment
            {
                get
                {
                    return this.environmentField;
                }
                set
                {
                    this.environmentField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("setting", IsNullable = false)]
            public testrunTestsuiteSetting[] settings
            {
                get
                {
                    return this.settingsField;
                }
                set
                {
                    this.settingsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("property", IsNullable = false)]
            public testrunTestsuiteProperty[] properties
            {
                get
                {
                    return this.propertiesField;
                }
                set
                {
                    this.propertiesField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("test-suite")]
            public testrunTestsuiteTestsuite testsuite
            {
                get
                {
                    return this.testsuiteField;
                }
                set
                {
                    this.testsuiteField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string id
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string fullname
            {
                get
                {
                    return this.fullnameField;
                }
                set
                {
                    this.fullnameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string runstate
            {
                get
                {
                    return this.runstateField;
                }
                set
                {
                    this.runstateField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public ushort testcasecount
            {
                get
                {
                    return this.testcasecountField;
                }
                set
                {
                    this.testcasecountField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class testrunTestsuiteEnvironment
        {

            public string frameworkversionField;

            public string clrversionField;

            public string osversionField;

            public string platformField;

            public string cwdField;

            public string machinenameField;

            public string userField;

            public string userdomainField;

            public string cultureField;

            public string uicultureField;

            public string osarchitectureField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute("framework-version")]
            public string frameworkversion
            {
                get
                {
                    return this.frameworkversionField;
                }
                set
                {
                    this.frameworkversionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute("clr-version")]
            public string clrversion
            {
                get
                {
                    return this.clrversionField;
                }
                set
                {
                    this.clrversionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute("os-version")]
            public string osversion
            {
                get
                {
                    return this.osversionField;
                }
                set
                {
                    this.osversionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string platform
            {
                get
                {
                    return this.platformField;
                }
                set
                {
                    this.platformField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string cwd
            {
                get
                {
                    return this.cwdField;
                }
                set
                {
                    this.cwdField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute("machine-name")]
            public string machinename
            {
                get
                {
                    return this.machinenameField;
                }
                set
                {
                    this.machinenameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string user
            {
                get
                {
                    return this.userField;
                }
                set
                {
                    this.userField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute("user-domain")]
            public string userdomain
            {
                get
                {
                    return this.userdomainField;
                }
                set
                {
                    this.userdomainField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string culture
            {
                get
                {
                    return this.cultureField;
                }
                set
                {
                    this.cultureField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string uiculture
            {
                get
                {
                    return this.uicultureField;
                }
                set
                {
                    this.uicultureField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute("os-architecture")]
            public string osarchitecture
            {
                get
                {
                    return this.osarchitectureField;
                }
                set
                {
                    this.osarchitectureField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class testrunTestsuiteSetting
        {

            public string nameField;

            public string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class testrunTestsuiteProperty
        {

            public string nameField;

            public string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class testrunTestsuiteTestsuite
        {

            public testrunTestsuiteTestsuiteTestsuite testsuiteField;

            public string typeField;

            public string idField;

            public string nameField;

            public string fullnameField;

            public string runstateField;

            public ushort testcasecountField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("test-suite")]
            public testrunTestsuiteTestsuiteTestsuite testsuite
            {
                get
                {
                    return this.testsuiteField;
                }
                set
                {
                    this.testsuiteField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string id
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string fullname
            {
                get
                {
                    return this.fullnameField;
                }
                set
                {
                    this.fullnameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string runstate
            {
                get
                {
                    return this.runstateField;
                }
                set
                {
                    this.runstateField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public ushort testcasecount
            {
                get
                {
                    return this.testcasecountField;
                }
                set
                {
                    this.testcasecountField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class testrunTestsuiteTestsuiteTestsuite
        {

            public testrunTestsuiteTestsuiteTestsuiteTestsuite testsuiteField;

            public string typeField;

            public string idField;

            public string nameField;

            public string fullnameField;

            public string runstateField;

            public ushort testcasecountField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("test-suite")]
            public testrunTestsuiteTestsuiteTestsuiteTestsuite testsuite
            {
                get
                {
                    return this.testsuiteField;
                }
                set
                {
                    this.testsuiteField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string id
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string fullname
            {
                get
                {
                    return this.fullnameField;
                }
                set
                {
                    this.fullnameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string runstate
            {
                get
                {
                    return this.runstateField;
                }
                set
                {
                    this.runstateField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public ushort testcasecount
            {
                get
                {
                    return this.testcasecountField;
                }
                set
                {
                    this.testcasecountField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class testrunTestsuiteTestsuiteTestsuiteTestsuite
        {

            public testrunTestsuiteTestsuiteTestsuiteTestsuiteTestsuite[] testsuiteField;

            public string typeField;

            public string idField;

            public string nameField;

            public string fullnameField;

            public string runstateField;

            public ushort testcasecountField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("test-suite")]
            public testrunTestsuiteTestsuiteTestsuiteTestsuiteTestsuite[] testsuite
            {
                get
                {
                    return this.testsuiteField;
                }
                set
                {
                    this.testsuiteField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string id
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string fullname
            {
                get
                {
                    return this.fullnameField;
                }
                set
                {
                    this.fullnameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string runstate
            {
                get
                {
                    return this.runstateField;
                }
                set
                {
                    this.runstateField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public ushort testcasecount
            {
                get
                {
                    return this.testcasecountField;
                }
                set
                {
                    this.testcasecountField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class testrunTestsuiteTestsuiteTestsuiteTestsuiteTestsuite
        {

            private testrunTestsuiteTestsuiteTestsuiteTestsuiteTestsuiteTestsuite[] testsuiteField;

            private string typeField;

            private string idField;

            private string nameField;

            private string fullnameField;

            private string runstateField;

            private ushort testcasecountField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("test-suite")]
            public testrunTestsuiteTestsuiteTestsuiteTestsuiteTestsuiteTestsuite[] testsuite
            {
                get
                {
                    return this.testsuiteField;
                }
                set
                {
                    this.testsuiteField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string id
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string fullname
            {
                get
                {
                    return this.fullnameField;
                }
                set
                {
                    this.fullnameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string runstate
            {
                get
                {
                    return this.runstateField;
                }
                set
                {
                    this.runstateField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public ushort testcasecount
            {
                get
                {
                    return this.testcasecountField;
                }
                set
                {
                    this.testcasecountField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class testrunTestsuiteTestsuiteTestsuiteTestsuiteTestsuiteTestsuite
        {

            private object[] itemsField;

            private string typeField;

            private string idField;

            private string nameField;

            private string fullnameField;

            private string runstateField;

            private ushort testcasecountField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("properties", typeof(testrunTestsuiteTestsuiteTestsuiteTestsuiteTestsuiteTestsuiteProperties))]
            [System.Xml.Serialization.XmlElementAttribute("test-case", typeof(testrunTestsuiteTestsuiteTestsuiteTestsuiteTestsuiteTestsuiteTestcase))]
            [System.Xml.Serialization.XmlElementAttribute("test-suite", typeof(testrunTestsuiteTestsuiteTestsuiteTestsuiteTestsuiteTestsuiteTestsuite))]
            public object[] Items
            {
                get
                {
                    return this.itemsField;
                }
                set
                {
                    this.itemsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string id
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string fullname
            {
                get
                {
                    return this.fullnameField;
                }
                set
                {
                    this.fullnameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string runstate
            {
                get
                {
                    return this.runstateField;
                }
                set
                {
                    this.runstateField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public ushort testcasecount
            {
                get
                {
                    return this.testcasecountField;
                }
                set
                {
                    this.testcasecountField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class testrunTestsuiteTestsuiteTestsuiteTestsuiteTestsuiteTestsuiteProperties
        {

            private testrunTestsuiteTestsuiteTestsuiteTestsuiteTestsuiteTestsuitePropertiesProperty[] propertyField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("property")]
            public testrunTestsuiteTestsuiteTestsuiteTestsuiteTestsuiteTestsuitePropertiesProperty[] property
            {
                get
                {
                    return this.propertyField;
                }
                set
                {
                    this.propertyField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class testrunTestsuiteTestsuiteTestsuiteTestsuiteTestsuiteTestsuitePropertiesProperty
        {

            private string nameField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class testrunTestsuiteTestsuiteTestsuiteTestsuiteTestsuiteTestsuiteTestcase
        {

            private testrunTestsuiteTestsuiteTestsuiteTestsuiteTestsuiteTestsuiteTestcaseProperty[] propertiesField;

            private string idField;

            private string nameField;

            private string fullnameField;

            private string methodnameField;

            private string classnameField;

            private string runstateField;

            private uint seedField;

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("property", IsNullable = false)]
            public testrunTestsuiteTestsuiteTestsuiteTestsuiteTestsuiteTestsuiteTestcaseProperty[] properties
            {
                get
                {
                    return this.propertiesField;
                }
                set
                {
                    this.propertiesField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string id
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string fullname
            {
                get
                {
                    return this.fullnameField;
                }
                set
                {
                    this.fullnameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string methodname
            {
                get
                {
                    return this.methodnameField;
                }
                set
                {
                    this.methodnameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string classname
            {
                get
                {
                    return this.classnameField;
                }
                set
                {
                    this.classnameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string runstate
            {
                get
                {
                    return this.runstateField;
                }
                set
                {
                    this.runstateField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public uint seed
            {
                get
                {
                    return this.seedField;
                }
                set
                {
                    this.seedField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class testrunTestsuiteTestsuiteTestsuiteTestsuiteTestsuiteTestsuiteTestcaseProperty
        {

            private string nameField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class testrunTestsuiteTestsuiteTestsuiteTestsuiteTestsuiteTestsuiteTestsuite
        {

            private object[] itemsField;

            private string typeField;

            private string idField;

            private string nameField;

            private string fullnameField;

            private string classnameField;

            private string runstateField;

            private ushort testcasecountField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("properties", typeof(testrunTestsuiteTestsuiteTestsuiteTestsuiteTestsuiteTestsuiteTestsuiteProperties))]
            [System.Xml.Serialization.XmlElementAttribute("test-case", typeof(testrunTestsuiteTestsuiteTestsuiteTestsuiteTestsuiteTestsuiteTestsuiteTestcase))]
            [System.Xml.Serialization.XmlElementAttribute("test-suite", typeof(testrunTestsuiteTestsuiteTestsuiteTestsuiteTestsuiteTestsuiteTestsuiteTestsuite))]
            public object[] Items
            {
                get
                {
                    return this.itemsField;
                }
                set
                {
                    this.itemsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string id
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string fullname
            {
                get
                {
                    return this.fullnameField;
                }
                set
                {
                    this.fullnameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string classname
            {
                get
                {
                    return this.classnameField;
                }
                set
                {
                    this.classnameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string runstate
            {
                get
                {
                    return this.runstateField;
                }
                set
                {
                    this.runstateField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public ushort testcasecount
            {
                get
                {
                    return this.testcasecountField;
                }
                set
                {
                    this.testcasecountField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class testrunTestsuiteTestsuiteTestsuiteTestsuiteTestsuiteTestsuiteTestsuiteProperties
        {

            private testrunTestsuiteTestsuiteTestsuiteTestsuiteTestsuiteTestsuiteTestsuitePropertiesProperty[] propertyField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("property")]
            public testrunTestsuiteTestsuiteTestsuiteTestsuiteTestsuiteTestsuiteTestsuitePropertiesProperty[] property
            {
                get
                {
                    return this.propertyField;
                }
                set
                {
                    this.propertyField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class testrunTestsuiteTestsuiteTestsuiteTestsuiteTestsuiteTestsuiteTestsuitePropertiesProperty
        {

            private string nameField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class testrunTestsuiteTestsuiteTestsuiteTestsuiteTestsuiteTestsuiteTestsuiteTestcase
        {

            private testrunTestsuiteTestsuiteTestsuiteTestsuiteTestsuiteTestsuiteTestsuiteTestcaseProperty[] propertiesField;

            private string idField;

            private string nameField;

            private string fullnameField;

            private string methodnameField;

            private string classnameField;

            private string runstateField;

            private uint seedField;

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("property", IsNullable = false)]
            public testrunTestsuiteTestsuiteTestsuiteTestsuiteTestsuiteTestsuiteTestsuiteTestcaseProperty[] properties
            {
                get
                {
                    return this.propertiesField;
                }
                set
                {
                    this.propertiesField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string id
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string fullname
            {
                get
                {
                    return this.fullnameField;
                }
                set
                {
                    this.fullnameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string methodname
            {
                get
                {
                    return this.methodnameField;
                }
                set
                {
                    this.methodnameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string classname
            {
                get
                {
                    return this.classnameField;
                }
                set
                {
                    this.classnameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string runstate
            {
                get
                {
                    return this.runstateField;
                }
                set
                {
                    this.runstateField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public uint seed
            {
                get
                {
                    return this.seedField;
                }
                set
                {
                    this.seedField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class testrunTestsuiteTestsuiteTestsuiteTestsuiteTestsuiteTestsuiteTestsuiteTestcaseProperty
        {

            private string nameField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class testrunTestsuiteTestsuiteTestsuiteTestsuiteTestsuiteTestsuiteTestsuiteTestsuite
        {

            private testrunTestsuiteTestsuiteTestsuiteTestsuiteTestsuiteTestsuiteTestsuiteTestsuiteProperty[] propertiesField;

            private testrunTestsuiteTestsuiteTestsuiteTestsuiteTestsuiteTestsuiteTestsuiteTestsuiteTestcase[] testcaseField;

            private string typeField;

            private string idField;

            private string nameField;

            private string fullnameField;

            private string classnameField;

            private string runstateField;

            private byte testcasecountField;

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("property", IsNullable = false)]
            public testrunTestsuiteTestsuiteTestsuiteTestsuiteTestsuiteTestsuiteTestsuiteTestsuiteProperty[] properties
            {
                get
                {
                    return this.propertiesField;
                }
                set
                {
                    this.propertiesField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("test-case")]
            public testrunTestsuiteTestsuiteTestsuiteTestsuiteTestsuiteTestsuiteTestsuiteTestsuiteTestcase[] testcase
            {
                get
                {
                    return this.testcaseField;
                }
                set
                {
                    this.testcaseField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string id
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string fullname
            {
                get
                {
                    return this.fullnameField;
                }
                set
                {
                    this.fullnameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string classname
            {
                get
                {
                    return this.classnameField;
                }
                set
                {
                    this.classnameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string runstate
            {
                get
                {
                    return this.runstateField;
                }
                set
                {
                    this.runstateField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte testcasecount
            {
                get
                {
                    return this.testcasecountField;
                }
                set
                {
                    this.testcasecountField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class testrunTestsuiteTestsuiteTestsuiteTestsuiteTestsuiteTestsuiteTestsuiteTestsuiteProperty
        {

            private string nameField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class testrunTestsuiteTestsuiteTestsuiteTestsuiteTestsuiteTestsuiteTestsuiteTestsuiteTestcase
        {

            private string idField;

            private string nameField;

            private string fullnameField;

            private string methodnameField;

            private string classnameField;

            private string runstateField;

            private uint seedField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string id
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string fullname
            {
                get
                {
                    return this.fullnameField;
                }
                set
                {
                    this.fullnameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string methodname
            {
                get
                {
                    return this.methodnameField;
                }
                set
                {
                    this.methodnameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string classname
            {
                get
                {
                    return this.classnameField;
                }
                set
                {
                    this.classnameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string runstate
            {
                get
                {
                    return this.runstateField;
                }
                set
                {
                    this.runstateField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public uint seed
            {
                get
                {
                    return this.seedField;
                }
                set
                {
                    this.seedField = value;
                }
            }
        }


    }
}
