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

namespace Math_Monkeys.Classes
{
    public struct Operand
    {
        int rangeMax;
        int rangeMin;
    }

    public enum Operation
    {
        None,
        Addition, 
        Subtraction,
        Multiplication,
        Division
    }

    class ProblemSet
    {
        #region member variables
       
        private uint id;
        private string name;
        private Operation operation;
        private Operand[] operand;

        #endregion

        #region properties

        public uint ID 
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

        #endregion

        private void init()
        {
            ID = 0;
            Name = string.Empty;
            Operation = Classes.Operation.None;
            Operand = new Operand[0];
        }

        #region constructors

        public ProblemSet()
        {
            init();            
        }

        public ProblemSet(uint id, string name, Operation operation, Operand[] operand)
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
