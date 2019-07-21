using System;
using System.Collections.Generic;
using System.Linq;

namespace BlackJack_4._0
{
    public class Deck
    {
        private List<Card> deck;

        public List<Card> GetDeck()
        {
            return this.deck;
        }

        public Deck(List<Card> cards)
        {
            this.deck = cards;
        }

        public Card PopCard()
        {
            var lastCard = deck.LastOrDefault();
            deck.Remove(lastCard);
            return lastCard;
        }

        public List<Card> Shuffle()
        {
            int rndNumber;
            Random rnd = new Random();

            for (int i = deck.Count - 1; i > 1; i--)
            {
                rndNumber = rnd.Next(i + 1);
                Card temp = deck[i];
                deck[i] = deck[rndNumber];
                deck[rndNumber] = temp;
            }
            return this.deck;
        }
    }
}
