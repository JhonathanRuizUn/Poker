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
                ShuffleDeck();
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

        public void ShuffleDeck()
        {
            Random rng = new Random();
            int n = Cards.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Card value = Cards[k];
                Cards[k] = Cards[n];
                Cards[n] = value;
            }
        }

        public Card DrawCard()
        {
            if (Cards == null || Cards.Count == 0)
            {
                throw new InvalidOperationException("No cards left in the deck");
            }
            Card card = Cards.First();
            Cards.RemoveAt(0);
            return card;
        }
    }
}