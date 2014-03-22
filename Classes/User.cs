/* *
 * Phase 1 Programmers: Jeff Cribben, Mary Venegas
 * Date Started:  February 11, 2014
 * Date Completed: March 4, 2014
 * This Class Name: User

 * MODIFIED
 * 
 * 13 March 2013  Jonathan Sanborn
 * Added enum
 * Made changes to prepare for altered xml files that include new fields
 * 15 March 2013 Harvey Mercado & Jonathan Sanborn
 * Updated user class to match changes made to XML structure
 * 
 * 21 March 2013 Jonathan Sanborn
 * Reorgnazied code to make it easier to read
 * 
 * * */



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Xml.Linq;
using System.IO;

namespace Math_Monkeys
{

    [XmlType("User")]
    public class User:IComparable
    {
        #region Member Variables

        private string id;
        private DateTime? lastLoginDate;
        private UserType type;
        private string firstName;
        private string lastName;
        private string screenName;
        private string password;

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

        [XmlElement("Date")]
        public DateTime? LastLoginDate
        {
            get 
            {
                return lastLoginDate;
            }
            set
            {
                if (value > DateTime.Now.AddDays(1.0))
                {
                    lastLoginDate = DateTime.Now;
                }
                else
                {
                    lastLoginDate = value;
                }
            }
        }

        [XmlElement("Type")]
        public UserType UserType
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
            }
        }

        public string GetUserTypeString
        {
            get
            {
                 return Enum.GetName(typeof(UserType),type);
            }
        }

        [XmlElement("First")]
        public string FirstName
        {
            get { return firstName; }
            set {
                if (value.Length <= 0 || value == null)
                {
                    firstName = string.Empty;
                }
                else
                {
                    firstName = value; 
                }
            }
        }

        [XmlElement("Last")]
        public string LastName
        {
            get { return lastName; }
            set
            {
                if (value.Length <= 0 || value == null)
                {
                    lastName = string.Empty;
                }
                else
                {
                    lastName = value;
                }
            }
        }

        [XmlElement("ScreenName")]
        public string ScreenName
        {
            get { return screenName; }
            set
            {
                if (value.Length <= 0 || value == null)
                {
                    screenName = string.Empty;
                }
                else if (value.Length > Properties.Settings.Default.StudentIDMax)
                {
                    value = value.Trim();
                    value = value.Substring(0, Properties.Settings.Default.StudentIDMax);
                    screenName = value;
                }
                else if (value.Length < Properties.Settings.Default.StudentIDMin)
                {
                    throw new FormatException("Value Screen Name is too short. Screen Name value must be at least "
                        + Properties.Settings.Default.StudentIDMin.ToString() + " characters long.");
                }
                else
                {
                    screenName = value;
                }
            }
        }

        [XmlElement("Password")]
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                if (value.Length <= 0 || value == null)
                {
                    password = string.Empty;
                }
                else
                {
                    password = value;
                }
            }
        }

        public string GetFullName 
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

        #endregion

        private void init()
        {
            ID = string.Empty;
            LastLoginDate = DateTime.MinValue;
            UserType =  UserType.None;
            FirstName = string.Empty;
            LastName = string.Empty;
            ScreenName = string.Empty;
            Password = string.Empty;
        }

        /// <summary>
        /// This method will compare two user objects for sorting.
        /// Jonathan Sanborn & Harvey Mercado
        /// 22 March 2014
        /// </summary>
        /// <param name="obj"> A user object to compare with this one. </param>
        /// <returns> int value based on user comparison</returns>
        public int CompareTo(object obj)
        {
            if (obj == null)
            { 
                return 1; 
            }

            User otherUser = obj as User;

            if (otherUser != null)
            {
                if (otherUser.UserType != this.UserType)
                {
                    return this.UserType.CompareTo(otherUser.UserType);
                }

                else
                {
                    return this.ScreenName.CompareTo(otherUser.ScreenName);
                }
            
            }

            else
            { 
                throw new ArgumentException("Object is not a user"); 
            }
        }


        #region constructors

        /// <summary>
        /// Default Constructor, creates an instance of User object.
        /// </summary>
        public User()
        {
            init();
        }

        /// <summary>
        /// Parameterized Constructor, creates an instancte of the user object with the passes in values
        /// </summary>
        /// <param name="id">A unique ID indentify the user</param>
        /// <param name="userType">A UserType Enumration value</param>
        /// <param name="fistName"></param>
        /// <param name="lastName"></param>
        /// <param name="screenName"></param>
        /// <param name="password"></param>
        public User(string id, UserType userType, string fistName, string lastName, string screenName, string password )
        {
            init();

            this.ID = id;
            this.UserType = userType;
            this.FirstName = fistName;
            this.LastName = lastName;
			this.ScreenName = screenName;
            this.Password = password;  
        }

        #endregion


        #region Depracated Code

        //private int _uniqueId;
        //private string _fullName;
        //private string _userType;
        //private DateTime? _LoginDate;

        //Name needs to be first and last
		//_fullName = fullName;
						
		//userType changed to enumeration
        //_userType = userType;

        //Replaced by first and last names
        //// Fields
        //// ListOfUsersXMLHandler userFile { get; set; }
        //[XmlElement("UserName")]
        //public string UserName
        //{
        //    get
        //    {
        //        return _fullName;
        //    }
        //    set
        //    {
        //        _fullName = value;
        //    }
        //}

        //Replaced by id and the unsigned int type
        //[XmlElement("UniqueID")]
        //public int UniqueID
        //{
        //    get
        //    {
        //        return _uniqueId;
        //    }
        //    set
        //    {
        //        _uniqueId = value;
        //    }
        //}

        /*
        // Methods
        // public bool GetFileData(); // get user data using UserXMLHandler
        // public bool StoreToFile(); // store user data using UserXMLHandler
        */
        //[XmlElement("UserType")]
        //public string UserType
        //{
        //    get
        //    {
        //        return _userType;
        //    }
        //    set
        //    {
        //        _userType = value;
        //    }// return "A" for Admin or "E" for EndUser
        //}

        #endregion

    }
}
