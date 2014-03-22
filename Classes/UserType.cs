using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Math_Monkeys
{
    [XmlType("Type")]
    public enum UserType
    {
        [XmlEnum(Name = "None")]
        None = 0,

        [XmlEnum(Name = "Administrator")]
        Administrator = 1,

        [XmlEnum(Name = "Student")]
        Student = 2
    };
}
