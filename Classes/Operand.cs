using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Math_Monkeys
{
    [XmlType("Operand")]
    public struct Operand
    {
        [XmlElement("RangeMax")]
        public int rangeMax;
        [XmlElement("RangeMin")]
        public int rangeMin;
    }
}
