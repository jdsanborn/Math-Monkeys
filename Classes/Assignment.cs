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

namespace Math_Monkeys
{
    [XmlType("Assignment")]
    class Assignment
    {
        #region member variables

        private string id;
        private string userID;
        private string problemSetID;
        private double goal;

        #endregion 

        #region properties

        [XmlElement("ID")]
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

        [XmlElement("UserID")]
        public string UserID
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
        public string ProblemSetID
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

        [XmlElement("Goal")]
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
            ID = string.Empty;
            UserID = string.Empty;
            ProblemSetID = string.Empty;
            Goal = 0.0;
        }

        #region constructors

        public Assignment()
        {
            init();
        }

        public Assignment(string id, string userID, string problemSetId, double goal)
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
