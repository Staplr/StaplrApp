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
        private Course(int id)
        {
            StudentList = new List<String>();
            AssistantList = new List<String>();
            ChapterList = new List<Chapter>();
            CourseInstructor = "";
        }

        public static Course CreateNewCourse()
        {
            return new Course(CourseCounter);
        }

        public String CourseName { get; set; }
        public int Id { get; set; }
        public List<String> StudentList { get; set; }
        public List<String> AssistantList { get; set; }
        public List<Chapter> ChapterList { get; set; }
        public String CourseInstructor { get; set; }
        public String Description { get; set; }

        protected static int CourseCounter
        {
            get
            {
                return __CourseCounter++;
            }
        }
        private volatile static int __CourseCounter = 0;
    }
}