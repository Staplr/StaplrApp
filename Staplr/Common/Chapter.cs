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

        public List<T> GetStapleType<T>() where T : Stapl.Stapl
        {
            List<T> returnList = new List<T>();

            for (int i = 0; i < StaplList.Count; i++)
            {
                if (typeof(T) == StaplList[i].GetType())
                {
                    returnList.Add((T)StaplList[i]);
                }
            }

            return returnList;
        }

        public int ChapterId { get; set; }
        public String ChapterName { get; set; }
        public String Description { get; set; }
        public List<Stapl.Stapl> StaplList { get; set; }
    }
}