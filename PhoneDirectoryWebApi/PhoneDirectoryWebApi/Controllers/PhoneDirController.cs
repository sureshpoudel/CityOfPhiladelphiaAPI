using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PhoneDirectoryWebApi.Controllers
{
    public class PhoneDirController : ApiController
    {
       

        public List<UserDetails> GetAllDepartment()
        {
            return LoadUserDetails();
        }

       

        public UserDetails GetAllDepartment(string fname, string lname)
        {


            List<UserDetails> userList = new List<UserDetails>();
            UserDetails user = new UserDetails();
            userList = LoadUserDetails();

           

            foreach (var item in userList)
            {
                if (item.Fname == fname && item.Lname == lname)
                {
                    user.Department = item.Department;
                    user.Phone = item.Phone;
                    user.Fname = item.Fname;
                    user.Lname = item.Lname;
                    break;
                }
            }
            return user;

        }

        public List<UserDetails> LoadUserDetails()
        {
            List<UserDetails> userList = new List<UserDetails>();

            UserDetails user1 = new UserDetails();


            user1.Fname = "Gerorge";
            user1.Lname = "Jetson";
            user1.Phone = "123-4560";
            user1.Department = "Spacely Sprockets";
            userList.Add(user1);

            UserDetails user2 = new UserDetails();

            user2.Fname = "Jane";
            user2.Lname = "Jetson";
            user2.Phone = "123-4560";
            user2.Department = "Spacely Sprockets";
            userList.Add(user2);

            UserDetails user3 = new UserDetails();

            user3.Fname = "Velma";
            user3.Lname = "Dinkley";
            user3.Phone = "987-6543";
            user3.Department = "Mystery Machine";
            userList.Add(user3);

            UserDetails user4 = new UserDetails();

            user4.Fname = "Daphne";
            user4.Lname = "Blake";
            user4.Phone = "654-3210";
            user4.Department = "Mystery Machine";
            userList.Add(user4);

            UserDetails user5 = new UserDetails();

            user5.Fname = "Norville";
            user5.Lname = "Rogers";
            user5.Phone = "321-9876";
            user5.Department = "Mystery Machine";
            userList.Add(user5);
            return userList;
        }
    }
    public class UserDetails
    {
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Phone { get; set; }
        public string Department { get; set; }
    }
}
