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
    public partial class Clash : Form
    {
        public Clash()
        {
            InitializeComponent();
        }

        private void rb_Player1_Clicked(object sender, EventArgs e)
        {
            if (rb_Player2.Checked)
            {
                rb_Player2.Checked = false;
            }
        }

        private void rb_Player2_Clicked(object sender, EventArgs e)
        {
            if (rb_Player1.Checked)
            {
                rb_Player1.Checked = false;
            }
        }
    }
}
