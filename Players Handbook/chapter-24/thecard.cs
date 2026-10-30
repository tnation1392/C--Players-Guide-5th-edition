using Players_Handbook.NewFolder;
using System;
using System.Collections.Generic;
using System.Text;

namespace Players_Handbook.NewFolder
{
    public class thecard
    {
        public enum Suit
        {
            Hearts,
            Diamonds,
            Clubs,
            Spades
        }

        public enum Rank
        {
            Two,
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
            public Suit suit { get; set; }
            public Rank rank { get; set; }
            public Card(Suit suit, Rank rank)
            {
                this.suit = suit;
                this.rank = rank;
            }
            public override string ToString()
            {
                return $"{rank} of {suit}";
            }
        }
    }


}

