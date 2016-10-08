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
            UserId = GenerateUserId;
        }

        public String Username { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Email { get; set; }
        public String Phone { get; set; }
        public List<String> CourseIdList { get; set; }
        public int UserId { get; }
        
        private volatile static int __UserIdCounter = 0;
        protected static int GenerateUserId
        {
            get
            {
                return __UserIdCounter++;
            }
        }
    }
}