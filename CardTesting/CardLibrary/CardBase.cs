using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardLibrary
{
    public class CardBase
    {
        private string cardName;
        private string cardValue;

        public CardBase()
        {
            cardName = null;
            cardValue = null;
        }

        public CardBase(string _CardName, string _CardValue)
        {
            cardName = _CardName;
            cardValue = _CardValue;
        }

        public bool IsGoodCard()
        {
            return cardValue != null ? true : false;
        }
        public string CardValue
        {
          get { return cardValue; }
          set { cardValue = value; }
        }
        public string CardName
        {
          get { return cardName; }
          set { cardName = value; }
        }
    }

    public class CardDeck
    {
        private List<CardBase> deck;

        public List<CardBase> Deck
        {
            get { return deck; }
            set { deck = value; }
        }

        public void ShuffleDeck()
        {
            List<CardBase> UnShuffledDeck = deck;
            List<CardBase> ShuffledDeck = new List<CardBase>();
            while (ShuffledDeck.Count > 0)
            {
                int indexToMove = new Random().Next(ShuffledDeck.Count);
                ShuffledDeck.Add(UnShuffledDeck[indexToMove]);
                UnShuffledDeck.RemoveAt(indexToMove);
            }
            deck = ShuffledDeck;
         }
        public CardBase DrawCard()
        {
            CardBase CardToReturn = new CardBase();
            if (deck.Count > 0)
            {
                CardToReturn = deck[0];
                deck.RemoveAt(0);
            }

            return CardToReturn;
        }
        public void AddCardToTop(CardBase CardToAdd)
        {
            deck.Insert(0, CardToAdd);
        }
        public void AddCardToBottom(CardBase CardToAdd)
        {
            deck.Insert(deck.Count, CardToAdd);
        }
    }
}
