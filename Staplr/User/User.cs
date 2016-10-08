using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Staplr.User
{
    public abstract class User
    {
        protected User()
        {
            //UserId = GenerateUserId;
            CourseIds = new List<int>();
        }

        public static User DecodeUser()
        {
            User newUser = new Student();
            return newUser;
        }
        
        public static byte[] EncodeUser(User user)
        {
            if (user.GetType() == typeof(Student))
            {

            }
            else if (user.GetType() == typeof(Instructor))
            {

            }

            // TODO: Actually do something here
            return new byte[0];
        }

        public String Username { get; set; }
        public String Name { get; set; }
        public String Email { get; set; }
        public List<int> CourseIds { get; set; }
        public int UserId { get; }
        
        //private volatile static int __UserIdCounter = 0;
        //protected static int GenerateUserId
        //{
        //    get
        //    {
        //        return __UserIdCounter++;
        //    }
        //}
    }
}