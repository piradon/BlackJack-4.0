using System.Collections.Generic;

namespace BlackJack_4._0
{
    internal class DeckFactory
    {
        public Deck CreateDeckForBlackJack()
        {
            List<Card> cards = CreateCards(4, 14);
            return new Deck(cards);
        }

        private List<Card> CreateCards(int numberOfSuits, int numberOfValues)
        {
            var cards = new List<Card>();

            for (int i = 0; i < numberOfSuits; i++)
            {
                for (int j = 1; j < numberOfValues; j++)
                {
                    cards.Add(new Card(j, i));
                }
            }
            return cards;
        }
    }
}
