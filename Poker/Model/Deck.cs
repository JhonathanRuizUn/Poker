using System;
using System.Collections.Generic;
using System.Linq;

namespace Poker.Model
{
    public class Deck
    {
        private List<Card>? Cards { get; set; }

        public Deck()
        {
            GenerateDeck();
            if (Cards != null)
            {
                ShuffleDeck(Cards);
            }
        }

        private void GenerateDeck()
        {
            Cards = new List<Card>();
            foreach (var suit in Enum.GetValues<Suit>())
            {
                foreach (var rank in Enum.GetValues<Rank>())
                {
                    Cards.Add(new Card(rank, suit));
                }
            }
            
        }

        public void ShuffleDeck(IList<Card> list)
        {
            Random rng = new Random();
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Card value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}