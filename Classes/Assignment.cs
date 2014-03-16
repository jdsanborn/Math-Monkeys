/* March 15, 2014 Jonathan Sanborn & Harvey Mercado
 * Filename: Assignment.cs
 * Classname: Assignment
 * 
 * Description: Class is used to associate the students with their assigned problem sets 
 * and goal of individual students to pass the assignment
 * CSUSM CS 441
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Math_Monkeys.Classes
{
    [XmlType("assignment")]
    class Assignment
    {
        #region member variables

        private uint id;
        private uint userID;
        private uint problemSetID;
        private double goal;

        #endregion 

        #region properties

        [XmlElement("id")]
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

        [XmlElement("userID")]
        public uint UserID
        {
            get
            {
                return userID;
            }
            set
            {
                userID = value;
            }
        }

        [XmlElement("ProblemSetID")]
        public uint ProblemSetID
        {
            get
            {
                return problemSetID;
            }
            set
            {
                problemSetID = value;
            }
        }

        [XmlElement("goal")]
        public double Goal
        {
            get
            {
                return goal;
            }
            set
            {
                if( value < 0.0)
                {
                    goal = 0.0;
                }
                else if (value > 1.0)
                {
                    goal = 1.0;
                }
                else
                {
                    goal = value;
                }
            }
        }

        #endregion

        private void init()
        {
            ID = 0;
            UserID = 0;
            ProblemSetID = 0;
            Goal = 0.0;
        }

        #region constructors

        public Assignment()
        {
            init();
        }

        public Assignment(uint id, uint userID, uint problemSetId, double goal)
        {
            init();

            this.ID = id;
            this.UserID = userID;
            this.ProblemSetID = problemSetId;
            this.Goal = goal;
        }

        #endregion
        

    }
}
