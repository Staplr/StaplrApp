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

namespace Staplr.Stapl.Poll
{
    public class Poll : Stapl
    {
        public Poll()
        {
            List<string> Options;
        }

        public void CreateOption()
        {

        }

        public void DisplayResults()
        {
            //switch to a results view
        }

        public void  RecordResponse()
        {
            //add response to list of responses
        }

        public List<String> OptionDescription { get; set; }
        public Dictionary<String, int> StudentResponses { get; set; }
    }

}