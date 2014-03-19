/* March 15, 2014 Jonathan Sanborn & Harvey Mercado
 * Filename: ProblemSet.cs
 * Classname: ProblemSet
 * Description: Class to represent individual problem sets that can be assigned to 0, 1, or many students
 * CSUSM CS 441
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Math_Monkeys
{
     [XmlType("operand")]
    public struct Operand
    {
          [XmlElement("rangeMax")]
        public int rangeMax;
          [XmlElement("rangeMin")]
        public int rangeMin;
    }

     [XmlType("operation")]
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

    [XmlType("problemSet")]
    class ProblemSet
    {
        #region member variables
       
        private string id;
        private string name;
        private Operation operation;
        private Operand[] operand;
        private uint numberOfProblems;

        #endregion

        #region properties

        [XmlElement("id")]
        public string ID 
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        [XmlElement("name")]
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value.Length >= 0 || value == null)
                {
                    name = string.Empty;
                }
                else
                {
                    name = value;
                }
            }
        }

        [XmlElement("operation")]
        public Operation Operation
        {
            get
            {
                return operation;
            }
            set
            {
                operation = value;
            }
        }

        [XmlElement("operand")]
        public Operand[] Operand
        {
            get
            {
                return operand;
            }
            set
            {
                operand = value;
            }
        }

        [XmlElement("numberOfProblems")]
        public uint NumberOfProblems
        {
            get
            {
                return numberOfProblems;
            }
            set
            {
                numberOfProblems = value;
            }
        }

        #endregion

        private void init()
        {
            ID = string.Empty;
            Name = string.Empty;
            Operation = Operation.None;
            Operand = new Operand[0];
        }

        #region constructors

        public ProblemSet()
        {
            init();            
        }

        public ProblemSet(string id, string name, Operation operation, Operand[] operand)
        {
            init();
            this.ID = id;
            this.Name = name;
            this.Operation = operation;
            this.Operand = operand;
        }

        #endregion
    }
}
