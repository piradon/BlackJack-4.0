namespace BlackJack_4._0
{
    public class Card
    {
        private int value;
        private int suit;

        public int Value
        {
            get { return this.value; }
            set { this.value = value; }
        }
        public int Suit
        {
            get { return suit; }
            set { this.suit = value; }
        }

        public Card(int value, int suit)
        {
            this.value = value;
            this.suit = suit;
        }
    }
}

