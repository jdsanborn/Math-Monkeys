using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Math_Monkeys
{

    [XmlType("Operation")]
    public enum Operation
    {
        [XmlEnum(Name = "None")]
        None,
        [XmlEnum(Name = "Addition")]
        Addition,
        [XmlEnum(Name = "Subtraction")]
        Subtraction,
        [XmlEnum(Name = "Multiplicaiton")]
        Multiplication,
        [XmlEnum(Name = "Division")]
        Division
    }
   
}
