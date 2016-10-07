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

using Staplr.User;

namespace Staplr.Common
{
    public class Course
    {
        public Course()
        {
            StudentList = new List<Student>();
            AssistantList = new List<Assistant>();
            CourseInstructor = new Instructor();
        }

        public String CourseName { get; set; }
        public List<Student> StudentList { get; set; }
        public List<Assistant> AssistantList { get; set; }
        public Instructor CourseInstructor { get; set; }
    }
}