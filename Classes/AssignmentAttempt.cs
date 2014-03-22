/* March 15, 2014 Jonathan Sanborn & Harvey Mercado
 * Filename: AssignmentAttempt.cs
 * Classname: AssignmentAttempt
 * 
 * Description: Records each attempt a student makes on a specific assignment
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
    /// <summary>
    /// 
    /// </summary>
     [XmlType("AssignmentAttempt")]
    class AssignmentAttempt
    {
        #region member variables

        private string id;
        private string assignmentID;
        private DateTime? date;
        private double grade;
        private TimeSpan timeSpent;

        #endregion

        #region properties

         /// <summary>
         /// 
         /// </summary>
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

        [XmlElement("AssignmentID")]
        public string AssignmentID
        {
            get
            {
                return assignmentID;
            }
            set
            {
                assignmentID = value;
            }
        }

        [XmlElement("Date")]
        public DateTime? Date
        {
            get
            {
                return date;
            }
            set
            {
                if (value > DateTime.Now.AddDays(1.0))
                {
                    date = DateTime.Now;
                }
                else if (value < DateTime.Now.AddYears(-5))
                {
                    date = DateTime.Now.AddYears(-5);
                }
                else
                {
                    date = value;
                }
            }
        }

        [XmlElement("Grade")]
        public double Grade
        {
            get
            {
                return grade;
            }
            set
            {
                if (value < 0.0)
                {
                    grade = 0.0;
                }
                else if (value > 1.0)
                {
                    grade = 1.0;
                }
                else
                {
                    grade = value;
                }
            }
        }

        [XmlElement("TimeSpent")]
        public TimeSpan TimeSpent
        {
            get
            {
                return timeSpent;
            }
            set
            {
                timeSpent = value;
            }
        }

        #endregion

        private void init()
        {
            this.ID = string.Empty;
            this.AssignmentID = string.Empty;
            this.Date = DateTime.MinValue;
            this.Grade = 0.0;
            this.TimeSpent = TimeSpan.Zero;
        }

        #region constructors

        public AssignmentAttempt()
        {
            init();

        }

        public AssignmentAttempt(string id, string assignmentID, DateTime? date, double grade, TimeSpan timeSpent)
        {
            init();

            this.ID = id;
            this.AssignmentID = assignmentID;
            this.Date = date;
            this.Grade = grade;
            this.TimeSpent = timeSpent;
        }

        #endregion
    }
}
