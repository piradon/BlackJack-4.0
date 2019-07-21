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
    public partial class Menu : UserControl
    {

        public Control ButtonStartGame { get { return this.buttonStartGame; } }
        public Control ButtonInstruction { get { return this.buttonInstruction; } }
        public Control LabelWelcome { get { return this.labelWelcome; } }

        public Menu()
        {
            InitializeComponent();
        }

        private void ButtonStartGame_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            Board board = new Board(this);
            this.Controls.Add(board);
        }

        private void ButtonInstruction_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            Instruction instruction = new Instruction(this);
            this.Controls.Add(instruction);
        }
    }
}
