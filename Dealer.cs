using System.Collections.Generic;

namespace BlackJack_4._0
{
    public class Dealer
    {
        private readonly Hand hand;
        private readonly Deck deck;

        public Dealer(Deck deck)
        {
            hand = new Hand(new List<Card>());
            this.deck = deck;
        }

        public void DealCardForDealer()
        {
            this.hand.AddCard(this.deck.PopCard());
        }

        public Card DealCard()
        {
            return deck.PopCard();
        }

        public Hand GetStartingHand()
        {
            var startingCards = new List<Card> {
                DealCard()
            };
            return new Hand(startingCards);
        }

        public int GetScore()
        {
            return this.hand.GetScore();
        }

        public int GetFirstCardScore()
        {
            return this.hand.GetFirstCardScore();
        }

        public List<Card> GetCards()
        {
            return this.hand.GetCards();
        }
    }
}

