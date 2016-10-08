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

namespace Staplr.Stapl.Deck
{
    public class Card
    {
        public Card()
        {
        }

        public void Flip()
        {
            //flips the flashcard to display the back view
        }

        public String Hint { get; set; }
        public String Answer { get; set; }
        public String Owner { get; set; }
        public int Upvotes { get; set; }
    }
}