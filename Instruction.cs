using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack_4._0
{
    public partial class Instruction : UserControl
    {
        public Instruction()
        {
            InitializeComponent();
        }

        private Menu menu = null;

        public Instruction(UserControl callingForm)
        {
            menu = callingForm as Menu;
            InitializeComponent();
            richTextBoxInstruction.LoadFile("F:\\clackjackrules.rtf");
        }

        private void ButtonBackToMenuFromGame_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(menu.ButtonStartGame);
            this.Controls.Add(menu.ButtonInstruction);
            this.Controls.Add(menu.LabelWelcome);
        }
    }
}
