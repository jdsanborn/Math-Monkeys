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
 * * */



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;

namespace Math_Monkeys
{
     [XmlType("type")]
    public enum UserType 
    {
        [XmlEnum(Name = "None")]
        None,

        [XmlEnum(Name = "Administrator")]
        Administrator,

        [XmlEnum(Name = "Student")]
        Student
    };

    [XmlType("User")]
    public class User
    {
        //private int _uniqueId;
        //private string _fullName;
        //private string _userType;
        //private DateTime? _LoginDate;


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

        [XmlElement("date")]
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

        [XmlElement("type")]
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

        [XmlElement("first")]
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

        [XmlElement("last")]
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

        [XmlElement("screenName")]
        public string ScreenName
        {
            get { return screenName; }
            set
            {
                if (value.Length <= 0 || value == null)
                {
                    screenName = string.Empty;
                }
                else
                {
                    screenName = value;
                }
            }
        }

        [XmlElement("password")]
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


        #region constructors

        public User()
        {
            init();
        }

        public User(string id, UserType userType, string fistName, string lastName, string screenName, string password )
        {
            init();

            //-1 value will not show up and will be assigned by the XML file
            this.ID = id;
            this.UserType = userType;
            this.FirstName = fistName;
            this.LastName = lastName;
			this.ScreenName = screenName;
            this.Password = password;

            //Name needs to be first and last
			//_fullName = fullName;
						
			//userType changed to enumeration
            //_userType = userType;
        }

        #endregion


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

    }
}
