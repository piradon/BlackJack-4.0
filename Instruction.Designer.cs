namespace BlackJack_4._0
{
    partial class Instruction
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
            this.richTextBoxInstruction = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // buttonBackToMenuFromGame
            // 
            this.buttonBackToMenuFromGame.BackColor = System.Drawing.Color.Black;
            this.buttonBackToMenuFromGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBackToMenuFromGame.Font = new System.Drawing.Font("Bahnschrift Condensed", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonBackToMenuFromGame.ForeColor = System.Drawing.Color.White;
            this.buttonBackToMenuFromGame.Location = new System.Drawing.Point(1676, 946);
            this.buttonBackToMenuFromGame.Name = "buttonBackToMenuFromGame";
            this.buttonBackToMenuFromGame.Size = new System.Drawing.Size(175, 53);
            this.buttonBackToMenuFromGame.TabIndex = 18;
            this.buttonBackToMenuFromGame.Text = "Menu";
            this.buttonBackToMenuFromGame.UseVisualStyleBackColor = false;
            this.buttonBackToMenuFromGame.Click += new System.EventHandler(this.ButtonBackToMenuFromGame_Click);
            // 
            // richTextBoxInstruction
            // 
            this.richTextBoxInstruction.BackColor = System.Drawing.Color.Black;
            this.richTextBoxInstruction.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxInstruction.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBoxInstruction.ForeColor = System.Drawing.Color.DarkGray;
            this.richTextBoxInstruction.Location = new System.Drawing.Point(333, 26);
            this.richTextBoxInstruction.Margin = new System.Windows.Forms.Padding(5);
            this.richTextBoxInstruction.Name = "richTextBoxInstruction";
            this.richTextBoxInstruction.ReadOnly = true;
            this.richTextBoxInstruction.Size = new System.Drawing.Size(1291, 681);
            this.richTextBoxInstruction.TabIndex = 19;
            this.richTextBoxInstruction.Text = "";
            // 
            // Instruction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.richTextBoxInstruction);
            this.Controls.Add(this.buttonBackToMenuFromGame);
            this.Name = "Instruction";
            this.Size = new System.Drawing.Size(1924, 1050);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonBackToMenuFromGame;
        private System.Windows.Forms.RichTextBox richTextBoxInstruction;
    }
}
