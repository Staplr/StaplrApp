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

namespace Staplr.Stapl.Note
{
    public class Note : Stapl
    {
        public Note()
        {

        }
        public String Content { get; set; }
    }

}