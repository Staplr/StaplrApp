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
    [Activity(Label = "CourseList")]
    class CourseListActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.CourseList);

            ListView someListView = FindViewById<ListView>(Resource.Id.courseListView);
            someListView.Id = Android.Resource.Id.List;
            Button bullshitButton = FindViewById<Button>(Resource.Id.button1);
            //this.ListAdapter = new ArrayAdapters<string>(this, Android.Resource.Layout.SimpleListItem1, test
        }
    }
}