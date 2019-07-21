using System;
using System.Drawing;
using System.IO;

namespace BlackJack_4._0
{
    public class DeckRenderer
    {
        private Bitmap allCards;

        public DeckRenderer()
        {
            this.allCards = LoadAllCards();
        }
        private Bitmap LoadAllCards()
        {
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Content\\image\\cards.png");
            Bitmap original = new Bitmap(path);
            return original;
        }
        public Bitmap GetCardFace(int value, int suit)
        {
            return this.allCards.Clone(new Rectangle((value - 1) * 79, suit * 123, 79, 123), allCards.PixelFormat);
        }
        
        public Bitmap ShowClosedCard()
        {
            Rectangle srcRect = new Rectangle(158, 492, 80, 123);
            Bitmap closedCard = allCards.Clone(srcRect, allCards.PixelFormat);
            return closedCard;
        }
    }
}
