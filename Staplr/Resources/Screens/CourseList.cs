using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Staplr.Common;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Staplr.Resources.Screens
{
    [Activity(Label = "CourseTable", MainLauncher = true)]
    public class CourseList : ListActivity
    {
        string[] items;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            items = new string[] { "test", "another test", "wheeeetests" };
            ListAdapter = new ArrayAdapter<String>(this, Android.Resource.Layout.SimpleListItem1, items);

        }
        
    }
}