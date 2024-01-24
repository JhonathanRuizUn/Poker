using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows.Documents;

namespace Poker.Model
{
    public enum Suit
    {
        Diamonds,
        Hearts,
        Clubs,
        Spades
    }
    public enum Rank
    {
        Two = 2,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace

    }
    public class Card
    {
        public Rank Rank { get; set; }
        public Suit Suit { get; set; }

        public Card(Rank rank, Suit suit) {
            Rank = rank;
            Suit = suit;
        }

        public override string ToString()
        {
            return $"{Rank}, {Suit}";
        }
    }


}
