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

namespace Staplr.Resources.Screens
{
    [Activity(Label = "@string/CourseList")]
    class CourseListActivity : ListActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            //this.ListAdapter = new ArrayAdapters<string>(this, Android.Resource.Layout.SimpleListItem1, test
        }
    }
}