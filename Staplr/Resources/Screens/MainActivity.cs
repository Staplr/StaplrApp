using System;
using System.Collections.Generic;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Staplr.Resources.Screens;

namespace Staplr
{
    [Activity(Label = "Staplr", MainLauncher = true, Icon = "@drawable/staplr")]
    public class MainActivity : Activity
    {
        //int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            EditText usernameEditText = FindViewById<EditText>(Resource.Id.usernameEditText);
            EditText pinEditText = FindViewById<EditText>(Resource.Id.pinEditText);
            Button signInButton = FindViewById<Button>(Resource.Id.signInButton);
            Button createAccountButton = FindViewById<Button>(Resource.Id.createAccountButton);
            Button forgotPasswordButton = FindViewById<Button>(Resource.Id.forgotPasswordButton);

            signInButton.Click += delegate
            {
                //sign in functionality
                var intent = new Intent(this, typeof(CourseListActivity));
                StartActivity(intent);
            };

            createAccountButton.Click += (object sender, EventArgs e) =>
            {
                //switch to account creation screen
            };

            forgotPasswordButton.Click += (object sender, EventArgs e) =>
            {
                //switch to forgot password screen
            };
            //// Get our button from the layout resource,
            //// and attach an event to it
            //Button button = FindViewById<Button>(Resource.Id.MyButton);

            //button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };
        }
    }
}

