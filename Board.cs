using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack_4._0
{
    public partial class Board : UserControl
    {
        Player player;
        Dealer dealer;
        Deck deck;
        DeckRenderer deckRenderer;

        public Board()
        {
            InitializeComponent();
        }

        private Menu menu = null;

        public Board(UserControl callingForm)
        {
            menu = callingForm as Menu;
            InitializeComponent();
        }

        private void Board_Load(object sender, EventArgs e)
        {
            deckRenderer = new DeckRenderer();
            StartNewGame();
        }

        private void ButtonBackToMenuFromGame_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(menu.ButtonStartGame);
            this.Controls.Add(menu.ButtonInstruction);
            this.Controls.Add(menu.LabelWelcome);
        }

        private void ButtonPlayAgain_Click(object sender, EventArgs e)
        {
            ClearAddedCardsFromBoard();
            EnableHitAndStandButton();
            StartNewGame();
        }

        int addedPlayerCardCounter = 0;
        int addedDealerCardCounter = 0;
        
        private void StartNewGame()
        {
            addedDealerCardCounter = 0;
            addedPlayerCardCounter = 0;

            deck = new DeckFactory().CreateDeckForBlackJack();
            deck.Shuffle();

            dealer = new Dealer(deck);
            player = new Player(dealer.GetStartingHand());

            dealer.DealCardForDealer();
            player.Hit(dealer.DealCard());
            dealer.DealCardForDealer();

            var playerCardOne = player.showCard().First();
            var playerCardTwo = player.showCard().LastOrDefault();

            var playerScore = player.GetScore();
            var dealerScore = dealer.GetScore();

            this.firstCardPlayerPicture.Image = deckRenderer.GetCardFace(playerCardOne.Value, playerCardOne.Suit);
            this.secondCardPlayerPicture.Image = deckRenderer.GetCardFace(playerCardTwo.Value, playerCardTwo.Suit);

            var dealerCards = dealer.GetCards();

            var dealerCardOne = dealerCards.First();
            var dealerCardTwo = dealerCards.LastOrDefault();

            this.firstCardDealerPicture.Image = deckRenderer.GetCardFace(dealerCardOne.Value, dealerCardOne.Suit);
            this.secondCardDealerPicture.Image = deckRenderer.ShowClosedCard();

            ShowGameComponents();

            this.labelYourCards.Text = "Your Cards";
            this.labelDealerCard.Text = "Dealers Cards";
            this.labelPlayerScore.Text = "Value " + playerScore;
            this.labelDealerScore.Text = "Value " + dealer.GetFirstCardScore();

            if (dealerScore == 21)
            {
                DisableHitAndStandButtons();
                ShowDealerHand();
                this.labelWinInformation.Text = "Dealer hit 21 on first try. You lose.";
                this.buttonPlayAgain.Show();
            }
            else if (playerScore == 21)
            {
                DisableHitAndStandButtons();
                ShowDealerHand();
                this.labelWinInformation.Text = "You hit 21 at first try. You won";
            }
        }

        private void ButtonHit_Click(object sender, EventArgs e)
        {
            Card hittedCard = dealer.DealCard();
            player.Hit(hittedCard);

            var playerScore = player.GetScore();
            var hittedCardPictureBox = new PictureBox
            {
                Image = deckRenderer.GetCardFace(hittedCard.Value, hittedCard.Suit),
                Location = new Point(340 + addedPlayerCardCounter * 100, 286),
                Size = new Size(100, 150),
                BackColor = Color.Black

            };

            this.Controls.Add(hittedCardPictureBox);
            this.labelPlayerScore.Text = "Value " + playerScore;
            addedPlayerCardCounter++;

            if (playerScore > 21)
            {
                DisableHitAndStandButtons();
                ShowDealerHand();
                this.labelWinInformation.Text = "You hit " + playerScore + ". You lose.";
                this.buttonPlayAgain.Show();
            }
            else if (playerScore == 21)
            {
                DisableHitAndStandButtons();
                ShowDealerHand();
                this.labelWinInformation.Text = "You hit " + playerScore + ". You won at once.";
                this.buttonPlayAgain.Show();
            } 
        }

        private void ButtonStand_Click(object sender, EventArgs e)
        {
            DisableHitAndStandButtons();
            ShowDealerHand();
            this.labelDealerScore.Text = "Value " + dealer.GetScore();

            while (dealer.GetScore() < 16)
            {

                labelWinInformation.Text = "Dealer has " + dealer.GetScore() + ". He must draw card.";
                Task.Delay(2000).Wait();

                dealer.DealCardForDealer();
                Card dealtCard = dealer.GetCards().LastOrDefault();


                var hittedCardPictureBox = new PictureBox
                {
                    Image = deckRenderer.GetCardFace(dealtCard.Value, dealtCard.Suit),
                    Location = new Point(1000 + addedDealerCardCounter * 100, 286),
                    Size = new Size(100, 150),
                    BackColor = Color.Black

                };

                this.Controls.Add(hittedCardPictureBox);
                this.labelDealerScore.Text = "Value " + dealer.GetScore();
                addedDealerCardCounter++;
            }

            var dealerScore = dealer.GetScore();
            var playerScore = player.GetScore();

            if ((dealerScore < 21) && (dealerScore > playerScore))
            {
                labelWinInformation.Text = "Dealer won (" + dealerScore + "), You (" + playerScore + ").";
            }

            else if (dealerScore == playerScore)
            {
                labelWinInformation.Text = "It is draw. Dealer wins.";
            }

            else if ((playerScore < 21) && (dealerScore < playerScore))
            {
                labelWinInformation.Text = "You won, You are closer to 21.";
            }

            else if (dealerScore > 21)
            {
                labelWinInformation.Text = "You won, Dealer extended 21 points (" + dealerScore + ").";
            }

            else if (dealerScore == 21)
            {
                labelWinInformation.Text = "Dealer draws exactly to 21. Dealer won";
            }
            this.labelDealerScore.Text = "Value " + dealerScore; 
        }

        private void ShowGameComponents()
        {
            this.labelWinInformation.Text = "Hit or Stand?";
            this.labelPlayerScore.Show();
            this.labelDealerScore.Show();
            this.labelDealerCard.Show();
            this.labelYourCards.Show();
        }

        private void ShowDealerHand()
        {
            this.secondCardDealerPicture.Image = deckRenderer.GetCardFace(dealer.GetCards()[1].Value, dealer.GetCards()[1].Suit);
            this.labelDealerScore.Text = "Value " + dealer.GetScore();
        }

        private void DisableHitAndStandButtons()
        {
            buttonStand.Enabled = false;
            buttonHit.Enabled = false;
        }

        private void EnableHitAndStandButton()
        {
            buttonStand.Enabled = true;
            buttonHit.Enabled = true;
        }
        
        private void ClearAddedCardsFromBoard()
        {
            int numberOfAllCardsAdded = addedDealerCardCounter + addedPlayerCardCounter;
            int numberOfAllControls = this.Controls.Count;

            while(numberOfAllCardsAdded!=0)
            {
                this.Controls.RemoveAt(this.Controls.Count-1);
                numberOfAllCardsAdded--;
            }

            addedDealerCardCounter = 0;
            addedPlayerCardCounter = 0;
        }
    }
}
