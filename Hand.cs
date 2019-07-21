using System.Collections.Generic;
using System.Linq;


namespace BlackJack_4._0
{
    public class Hand
    {
        private List<Card> cards;

        public Hand(List<Card> cards)
        {
            this.cards = cards;
        }
        public void AddCard(Card card)
        {
            cards.Add(card);
        }

        public int GetScore()
        {
            var score = cards.Sum(item =>
            {
                if (item.Value >= 10)
                {
                    return 10;
                }
                return item.Value;
            });

            if (score < 13 && cards.Find(i => i.Value == 1) != null)
            {
                Card aceCard = cards.Find(i => i.Value == 1);
                score += 10;
            }

            return score;
        }

        public int GetFirstCardScore()
        {
            var score = cards[0].Value;
            if (score >= 10)
            {
                score = 10;
            }
            else if (score == 1)
            {
                score = 11;
            }

            return score;
        }

        public List<Card> GetCards()
        {
            return this.cards;
        }
    }
}
