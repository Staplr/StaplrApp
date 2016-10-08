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
    public class Instructor : User
    {
        public Instructor() : base()
        {
            CoursesTaught = new List<int>();
        }

        public List<int> CoursesTaught { get; set; }
    }
}