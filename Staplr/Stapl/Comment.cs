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

namespace Staplr.Stapl
{
    public class Comment
    {
        public Comment()
        {

        }

        public String Content { get; set; }
        public String Owner { get; set; }
        public DateTime Timestamp { get; set; }
    }
}