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

using Staplr.Stapl;

namespace Staplr.Common
{
    public class Chapter
    {
        public Chapter(String chapterName)
        {
            StaplList = new List<Stapl.Stapl>();
            ChapterName = chapterName;
        }

        public String ChapterName { get; set; }
        public List<Stapl.Stapl> StaplList { get; set; }
    }
}