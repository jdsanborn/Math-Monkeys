﻿/* *
 * Phase 1 Programmers: Jeff Cribben, Mary Venegas
 * Date Started:  February 11, 2014
 * Date Completed: March 4, 2014
 * This Class Name: User
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Math_Monkeys
{
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
        private int _uniqueId;
        private string _fullName;
        private string _userType;
        private DateTime? _LoginDate;


        #region Member Variables

        private uint id;
        private DateTime? lastLoginDate;
        private UserType type;
        private string firstName;
        private string lastName;
        private string screenName;
        private string password;

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
                
                if (value < 0)
                {
                    id = 0;
                }
                else if (value > uint.MaxValue)
                {
                    id = uint.MaxValue;
                }
                else
                {
                    id = value;
                }
            }
        }

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
                else if (value < DateTime.Now.AddYears(-5))
                {
                    lastLoginDate = DateTime.Now.AddYears(-5);
                }
                else
                {
                    lastLoginDate = value;
                }
            }
        }

        public UserType Type
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

        #endregion

        private void init()
        {
            ID = 0;
            LastLoginDate = DateTime.MinValue;
            Type =  UserType.None;
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

        public User(int Id, string fullName, string userType)
        {
            init();

            //-1 value will not show up and will be assigned by the XML file
            _uniqueId = Id;
            _fullName = fullName;
            _userType = userType;
        }

        #endregion

        // Fields
        // ListOfUsersXMLHandler userFile { get; set; }
        [XmlElement("UserName")]
        public string UserName
        {
            get
            {
                return _fullName;
            }
            set
            {
                _fullName = value;
            }
        }
        [XmlElement("UniqueID")]
        public int UniqueID
        {
            get
            {
                return _uniqueId;
            }
            set
            {
                _uniqueId = value;
            }
        }
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
        public DateTime? LoginDate
        {
            get
            {
                return _LoginDate; 
            }
            set
            {
                _LoginDate = value;
            }
        }
    }
}
