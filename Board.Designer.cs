namespace BlackJack_4._0
{
    partial class Board
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonBackToMenuFromGame = new System.Windows.Forms.Button();
            this.buttonPlayAgain = new System.Windows.Forms.Button();
            this.labelWinInformation = new System.Windows.Forms.Label();
            this.labelPlayerScore = new System.Windows.Forms.Label();
            this.buttonStand = new System.Windows.Forms.Button();
            this.buttonHit = new System.Windows.Forms.Button();
            this.labelDealerScore = new System.Windows.Forms.Label();
            this.labelDealerCard = new System.Windows.Forms.Label();
            this.secondCardDealerPicture = new System.Windows.Forms.PictureBox();
            this.firstCardDealerPicture = new System.Windows.Forms.PictureBox();
            this.labelYourCards = new System.Windows.Forms.Label();
            this.firstCardPlayerPicture = new System.Windows.Forms.PictureBox();
            this.secondCardPlayerPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.secondCardDealerPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstCardDealerPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstCardPlayerPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondCardPlayerPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBackToMenuFromGame
            // 
            this.buttonBackToMenuFromGame.BackColor = System.Drawing.Color.Black;
            this.buttonBackToMenuFromGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBackToMenuFromGame.Font = new System.Drawing.Font("Bahnschrift Condensed", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonBackToMenuFromGame.ForeColor = System.Drawing.Color.White;
            this.buttonBackToMenuFromGame.Location = new System.Drawing.Point(1675, 933);
            this.buttonBackToMenuFromGame.Name = "buttonBackToMenuFromGame";
            this.buttonBackToMenuFromGame.Size = new System.Drawing.Size(175, 53);
            this.buttonBackToMenuFromGame.TabIndex = 17;
            this.buttonBackToMenuFromGame.Text = "Menu";
            this.buttonBackToMenuFromGame.UseVisualStyleBackColor = false;
            this.buttonBackToMenuFromGame.Click += new System.EventHandler(this.ButtonBackToMenuFromGame_Click);
            // 
            // buttonPlayAgain
            // 
            this.buttonPlayAgain.BackColor = System.Drawing.Color.Black;
            this.buttonPlayAgain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlayAgain.Font = new System.Drawing.Font("Bahnschrift Condensed", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPlayAgain.ForeColor = System.Drawing.Color.White;
            this.buttonPlayAgain.Location = new System.Drawing.Point(1675, 863);
            this.buttonPlayAgain.Name = "buttonPlayAgain";
            this.buttonPlayAgain.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonPlayAgain.Size = new System.Drawing.Size(175, 53);
            this.buttonPlayAgain.TabIndex = 16;
            this.buttonPlayAgain.Text = "Play Again";
            this.buttonPlayAgain.UseVisualStyleBackColor = false;
            this.buttonPlayAgain.Click += new System.EventHandler(this.ButtonPlayAgain_Click);
            // 
            // labelWinInformation
            // 
            this.labelWinInformation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelWinInformation.BackColor = System.Drawing.Color.Transparent;
            this.labelWinInformation.Font = new System.Drawing.Font("Bahnschrift Condensed", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWinInformation.ForeColor = System.Drawing.Color.White;
            this.labelWinInformation.Location = new System.Drawing.Point(608, 267);
            this.labelWinInformation.Name = "labelWinInformation";
            this.labelWinInformation.Size = new System.Drawing.Size(632, 75);
            this.labelWinInformation.TabIndex = 28;
            this.labelWinInformation.Text = "Info Table";
            this.labelWinInformation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPlayerScore
            // 
            this.labelPlayerScore.AutoSize = true;
            this.labelPlayerScore.BackColor = System.Drawing.Color.Transparent;
            this.labelPlayerScore.Font = new System.Drawing.Font("Bahnschrift Condensed", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPlayerScore.ForeColor = System.Drawing.Color.White;
            this.labelPlayerScore.Location = new System.Drawing.Point(296, 645);
            this.labelPlayerScore.Name = "labelPlayerScore";
            this.labelPlayerScore.Size = new System.Drawing.Size(207, 39);
            this.labelPlayerScore.TabIndex = 24;
            this.labelPlayerScore.Text = "Player Hand Value";
            this.labelPlayerScore.Visible = false;
            // 
            // buttonStand
            // 
            this.buttonStand.BackColor = System.Drawing.Color.White;
            this.buttonStand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStand.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonStand.Location = new System.Drawing.Point(212, 285);
            this.buttonStand.Name = "buttonStand";
            this.buttonStand.Size = new System.Drawing.Size(294, 57);
            this.buttonStand.TabIndex = 27;
            this.buttonStand.Text = "Stand";
            this.buttonStand.UseVisualStyleBackColor = false;
            this.buttonStand.Click += new System.EventHandler(this.ButtonStand_Click);
            // 
            // buttonHit
            // 
            this.buttonHit.BackColor = System.Drawing.Color.White;
            this.buttonHit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHit.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonHit.Location = new System.Drawing.Point(212, 237);
            this.buttonHit.Name = "buttonHit";
            this.buttonHit.Size = new System.Drawing.Size(294, 51);
            this.buttonHit.TabIndex = 26;
            this.buttonHit.Text = "Hit";
            this.buttonHit.UseVisualStyleBackColor = false;
            this.buttonHit.Click += new System.EventHandler(this.ButtonHit_Click);
            // 
            // labelDealerScore
            // 
            this.labelDealerScore.AutoSize = true;
            this.labelDealerScore.BackColor = System.Drawing.Color.Transparent;
            this.labelDealerScore.Font = new System.Drawing.Font("Bahnschrift Condensed", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDealerScore.ForeColor = System.Drawing.Color.White;
            this.labelDealerScore.Location = new System.Drawing.Point(1283, 648);
            this.labelDealerScore.Name = "labelDealerScore";
            this.labelDealerScore.Size = new System.Drawing.Size(208, 39);
            this.labelDealerScore.TabIndex = 25;
            this.labelDealerScore.Text = "Dealer Hand Value";
            this.labelDealerScore.Visible = false;
            // 
            // labelDealerCard
            // 
            this.labelDealerCard.AutoSize = true;
            this.labelDealerCard.BackColor = System.Drawing.Color.Transparent;
            this.labelDealerCard.Font = new System.Drawing.Font("Bahnschrift Condensed", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDealerCard.ForeColor = System.Drawing.Color.White;
            this.labelDealerCard.Location = new System.Drawing.Point(1224, 379);
            this.labelDealerCard.Name = "labelDealerCard";
            this.labelDealerCard.Size = new System.Drawing.Size(203, 48);
            this.labelDealerCard.TabIndex = 22;
            this.labelDealerCard.Text = "Dealers Cards";
            this.labelDealerCard.Visible = false;
            // 
            // secondCardDealerPicture
            // 
            this.secondCardDealerPicture.BackColor = System.Drawing.Color.Transparent;
            this.secondCardDealerPicture.Location = new System.Drawing.Point(1344, 439);
            this.secondCardDealerPicture.Name = "secondCardDealerPicture";
            this.secondCardDealerPicture.Size = new System.Drawing.Size(144, 187);
            this.secondCardDealerPicture.TabIndex = 23;
            this.secondCardDealerPicture.TabStop = false;
            // 
            // firstCardDealerPicture
            // 
            this.firstCardDealerPicture.BackColor = System.Drawing.Color.Transparent;
            this.firstCardDealerPicture.Location = new System.Drawing.Point(1194, 439);
            this.firstCardDealerPicture.Name = "firstCardDealerPicture";
            this.firstCardDealerPicture.Size = new System.Drawing.Size(144, 187);
            this.firstCardDealerPicture.TabIndex = 20;
            this.firstCardDealerPicture.TabStop = false;
            // 
            // labelYourCards
            // 
            this.labelYourCards.AutoSize = true;
            this.labelYourCards.BackColor = System.Drawing.Color.Transparent;
            this.labelYourCards.Font = new System.Drawing.Font("Bahnschrift Condensed", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelYourCards.ForeColor = System.Drawing.Color.White;
            this.labelYourCards.Location = new System.Drawing.Point(267, 379);
            this.labelYourCards.Name = "labelYourCards";
            this.labelYourCards.Size = new System.Drawing.Size(164, 48);
            this.labelYourCards.TabIndex = 21;
            this.labelYourCards.Text = "Your Cards ";
            this.labelYourCards.Visible = false;
            // 
            // firstCardPlayerPicture
            // 
            this.firstCardPlayerPicture.BackColor = System.Drawing.Color.Transparent;
            this.firstCardPlayerPicture.Location = new System.Drawing.Point(212, 439);
            this.firstCardPlayerPicture.Name = "firstCardPlayerPicture";
            this.firstCardPlayerPicture.Size = new System.Drawing.Size(144, 187);
            this.firstCardPlayerPicture.TabIndex = 18;
            this.firstCardPlayerPicture.TabStop = false;
            // 
            // secondCardPlayerPicture
            // 
            this.secondCardPlayerPicture.BackColor = System.Drawing.Color.Transparent;
            this.secondCardPlayerPicture.Location = new System.Drawing.Point(362, 439);
            this.secondCardPlayerPicture.Name = "secondCardPlayerPicture";
            this.secondCardPlayerPicture.Size = new System.Drawing.Size(144, 187);
            this.secondCardPlayerPicture.TabIndex = 19;
            this.secondCardPlayerPicture.TabStop = false;
            // 
            // Board
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.labelWinInformation);
            this.Controls.Add(this.labelPlayerScore);
            this.Controls.Add(this.buttonStand);
            this.Controls.Add(this.buttonHit);
            this.Controls.Add(this.labelDealerScore);
            this.Controls.Add(this.labelDealerCard);
            this.Controls.Add(this.secondCardDealerPicture);
            this.Controls.Add(this.firstCardDealerPicture);
            this.Controls.Add(this.labelYourCards);
            this.Controls.Add(this.firstCardPlayerPicture);
            this.Controls.Add(this.secondCardPlayerPicture);
            this.Controls.Add(this.buttonBackToMenuFromGame);
            this.Controls.Add(this.buttonPlayAgain);
            this.DoubleBuffered = true;
            this.Name = "Board";
            this.Size = new System.Drawing.Size(1924, 1050);
            this.Load += new System.EventHandler(this.Board_Load);
            ((System.ComponentModel.ISupportInitialize)(this.secondCardDealerPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstCardDealerPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstCardPlayerPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondCardPlayerPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBackToMenuFromGame;
        private System.Windows.Forms.Button buttonPlayAgain;
        private System.Windows.Forms.Label labelWinInformation;
        private System.Windows.Forms.Label labelPlayerScore;
        private System.Windows.Forms.Button buttonStand;
        private System.Windows.Forms.Button buttonHit;
        private System.Windows.Forms.Label labelDealerScore;
        private System.Windows.Forms.Label labelDealerCard;
        private System.Windows.Forms.PictureBox secondCardDealerPicture;
        private System.Windows.Forms.PictureBox firstCardDealerPicture;
        private System.Windows.Forms.Label labelYourCards;
        private System.Windows.Forms.PictureBox firstCardPlayerPicture;
        private System.Windows.Forms.PictureBox secondCardPlayerPicture;
    }
}
