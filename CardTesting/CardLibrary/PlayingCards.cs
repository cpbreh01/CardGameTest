using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardLibrary
{
    public class PlayingCard : CardBase
    {
        public enum Suit { Clubs, Spades, Hearts, Diamonds };
        public enum Color { Black, Red };
        public enum CardValue { Ace = 0, One = 1, Two = 2, Three = 3, Four = 4, Five = 5, Six = 6, Seven = 7, Eight = 8, Nine = 9, Ten = 10, Jack = 11, Queen = 12, King = 13 };

        private Suit cardSuit;
        private Color cardColor;

        public Suit CardSuit
        {
            get { return cardSuit; }
        }
        public Color CardColor
        {
            get { return cardColor; }
        }

        public PlayingCard(CardValue _CardValue, Suit _suit) : base (string.Format("{0} of {1}",_CardValue, _suit), _CardValue.ToString())
        {
            cardSuit = _suit;
            if (_suit == Suit.Clubs || _suit == Suit.Spades)
            {
                cardColor = Color.Black;
            }else
            {
                cardColor = Color.Red;
            }
        }

    }

    public class PlayingDeck : CardDeck
    {
        private override List<PlayingCard> deck;
        public List<PlayingDeck> Deck
        {
            get { return deck; }
            set { deck = value; }
        }


        public PlayingDeck() : base ()
        {
            this.deck = CreatePlayingCardDeck();
        }

        private List<PlayingCard> CreatePlayingCardDeck()
        {
            deck = new List<PlayingCard>();
            foreach (PlayingCard.Suit _suit in Enum.GetValues(typeof(PlayingCard.Suit)))
            {
                foreach (PlayingCard.CardValue _faceValue in Enum.GetValues(typeof(PlayingCard.CardValue)))
                {
                    deck.Add(new PlayingCard(_faceValue, _suit));
                }
            }

            return deck;
        }


    }

}
