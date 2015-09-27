using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShrinkingGame
{
    public partial class StartUp : Form
    {
        public StartUp()
        {
            InitializeComponent();
        }

        private void btn_Game1_Click(object sender, EventArgs e)
        {
            Form1 oldGame = new Form1();
            Hide();
            oldGame.Closed += (s, args) => this.Close();
            oldGame.Show();
        }

        private void btn_Game2_Click(object sender, EventArgs e)
        {
            Clash battleForm = new Clash();
            Hide();
            battleForm.Closed += (s, args) => this.Close();
            battleForm.Show();
        }
    }
}
