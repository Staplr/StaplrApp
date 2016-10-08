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
    class Deck : Stapl
    {
        public Deck()
        {
            CardList = new List<Card>();
        }

        public void Shuffle()
        {
            Random randomNumberGenerator = new Random(DateTime.Now.Millisecond);

            for (int i = 0; i < CardList.Count; i++)
            {
                int index1 = randomNumberGenerator.Next(0, CardList.Count - 1);
                int index2 = randomNumberGenerator.Next(0, CardList.Count - 1);
                Card tempCard = CardList[index1];
                CardList[index1] = CardList[index2];
                CardList[index2] = tempCard;
            }
        }

        public List<Card> CardList { get; set; }
    }
}