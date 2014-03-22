/* *
 * Phase 1 Programmers: Jeff Cribben, Mary Venegas
 * Date Started:  February 11, 2014
 * Date Completed: March 4, 2014
 * This Class Name: 
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Math_Monkeys
{
     [XmlType("User")]
    class Admin : User
    {
        private void init()
        {

        }

        public Admin() : base()
        {
            init();
        }

         public Admin(string id, UserType userType, string fistName, string lastName, string screenName, string password)
            :base(id, userType, fistName, lastName, screenName, password )
        {
            init();
        }

        public Admin(User user) : base()
        {
            init();
            
            this.ID = user.ID;
            this.UserType = user.UserType;
            this.FirstName = user.FirstName;
            this.LastName = user.LastName;
            this.ScreenName = user.ScreenName;
            this.Password = user.Password;
            this.LastLoginDate = user.LastLoginDate;
        }
    }
}
