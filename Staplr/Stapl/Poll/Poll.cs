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
            AllowVoteChanges = false;
            OptionDescription = new List<string>();
            StudentResponses = new Dictionary<string, int>();
            ActiveStarting = DateTime.Now;
            ActiveUntil = new DateTime(ActiveStarting.Ticks);
        }
        
        public void DisplayResults()
        {
            //switch to a results view
        }

        public void RecordResponse(String student, int response)
        {

            if (response >= OptionDescription.Count)
            {
                Console.WriteLine("Error! Their choice was too big to work, not too big to fail");
            }
            else if (!IsThePollCurrentlyActive)
            {
                Console.WriteLine("Well shucks, you can't take the poll right now!");
            }
            else if (AllowVoteChanges || !StudentResponses.ContainsKey(student))
            {
                StudentResponses[student] = response;
            }
        }

        public bool AllowVoteChanges { get; set; }
        public bool IsThePollCurrentlyActive { get
            {
                if (ActiveStarting >= DateTime.Now || (ActiveStarting != ActiveUntil && ActiveUntil <= DateTime.Now))
                {
                    return false;
                }

                return true;
            }
        }
        public DateTime ActiveUntil { get; set; }
        public DateTime ActiveStarting { get; set; }
        public List<String> OptionDescription { get; set; }
        public Dictionary<String, int> StudentResponses { get; set; }
    }

}