using System.Collections.Generic;

namespace BlackJack_4._0
{
    public class Player
    {
        private readonly Hand hand;
        public Player(Hand hand)
        {
            this.hand = hand;
        }

        public void Hit(Card card)
        {
            hand.AddCard(card);
        }

        public int GetScore()
        {
            return this.hand.GetScore();
        }

        public List<Card> showCard()
        {
            return this.hand.GetCards();
        }
    }
}
