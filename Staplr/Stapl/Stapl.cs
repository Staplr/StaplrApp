using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Staplr.User;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Staplr.Stapl
{
    public class Stapl
    {
        public Stapl()
        {
        }

        public String Title { get; set; }
        public bool IsPublic { get; set; }
        public bool CommentsAllowed { get; set; }
        public List<Comment> CommentList { get; set; }
    }
}