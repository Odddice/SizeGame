using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShrinkingGame;
using System.IO;

namespace ShrinkingGame
{
    public partial class Form1 : Form
    {
        //Initialized value setup.
        bool p1Turn = true;
        bool firstTurn = true;


        public Form1()
        {
            InitializeComponent();
        }

        //the Roll button has been clicked.
        private void btnRoll_Click(object sender, EventArgs e)
        {
            ChangeSize();
            p1Turn = !p1Turn;
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtBFLink.Text);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSize1.Text = txtStartP1.Text;
            txtSize2.Text = txtStartP2.Text;
            VarStorage.Globals.player1Height = Convert.ToDouble(txtStartP1.Text);
            VarStorage.Globals.player2Height = Convert.ToDouble(txtStartP2.Text);
            p1Turn = true;
            firstTurn = true;
            txtDisplay.Text = "";
            txtBFLink.Text = "";
            txtRecap.Text = "";
        }

        public void ChangeSize()
        {
            //Create a random number gen and height gen
            CryptoRandom rnd = new CryptoRandom();
            HeightGen conv = new HeightGen();

            //set values on the first turn only.
            if (firstTurn == true)
            {
                VarStorage.Globals.player1Height = Convert.ToDouble(txtStartP1.Text);
                VarStorage.Globals.player2Height = Convert.ToDouble(txtStartP2.Text);
                firstTurn = false;
            }
            
            //Checks who's turn it is, then sets global variables.
            if (p1Turn == true)
            {
                VarStorage.Globals.mainName = txtP1Name.Text;
                VarStorage.Globals.otherName = txtP2Name.Text;
                VarStorage.Globals.mainSize = VarStorage.Globals.player1Height;
                VarStorage.Globals.otherSize = VarStorage.Globals.player2Height;
            }
            else
            {
                VarStorage.Globals.mainName = txtP2Name.Text;
                VarStorage.Globals.otherName = txtP1Name.Text;
                VarStorage.Globals.mainSize = VarStorage.Globals.player2Height;
                VarStorage.Globals.otherSize = VarStorage.Globals.player1Height;
            }

            //Rolls to see which change to make, then executes said change.
            int rNumber = rnd.Next(100) + 1;
                ChangeHandler theChange = new ChangeHandler();
            if (rNumber >= 1 && rNumber <= 10)
            {
                VarStorage.Globals.rollType = 1;
                theChange.Changing();
            }
            else if (rNumber >= 11 && rNumber <= 50)
            {
                VarStorage.Globals.rollType = 2;
                theChange.Changing();
            }
            else if (rNumber >=51 && rNumber <= 60)
            {
                VarStorage.Globals.rollType = 3;
                theChange.Changing();
            }
            else
            {
                VarStorage.Globals.rollType = 4;
                theChange.Changing();
            }

            //Checks the turn and then sets the main height variables.
            if (p1Turn == true)
            {
                VarStorage.Globals.player1Height = VarStorage.Globals.mainFinalSize;
                VarStorage.Globals.player2Height = VarStorage.Globals.otherFinalSize;
            }
            else
            {
                VarStorage.Globals.player1Height = VarStorage.Globals.otherFinalSize;
                VarStorage.Globals.player2Height = VarStorage.Globals.mainFinalSize;
            }


            //Creates the text that is displayed in the main textbox.
            txtDisplay.Text += VarStorage.Globals.textLine1;
            txtDisplay.Text += Environment.NewLine;
            txtDisplay.Text += Environment.NewLine;

            //Finds closest object sizes.
            List<int> objects = new List<int> { 304800, 762000, 1828800, 7493000};
            int relativeSize = Convert.ToInt32(VarStorage.Globals.mainFinalSize);
            string compObject = "";
  /*
            if (VarStorage.Globals.player1Height >= VarStorage.Globals.player2Height)
            { relativeSize = Convert.ToInt32(VarStorage.Globals.player1Height * 12); }
            else
            { relativeSize = Convert.ToInt32(VarStorage.Globals.player2Height * 12); }
   */
            double closest = objects.Aggregate((x, y) => Math.Abs(x - relativeSize) < Math.Abs(y - relativeSize) ? x : y);
            if (closest == 304800)
            { compObject = "Rabbit"; }
            else if (closest == 762000)
            { compObject = "Wolf"; }
            else if (closest == 1828800)
            { compObject = "SUV"; }
            

            //Creates text for the comparison textbox.
            VarStorage.Globals.textLine2 = VarStorage.Globals.mainName + " now appears " + conv.totalHeight(Convert.ToInt32(VarStorage.Globals.mainCompSize)) + " to the " + conv.totalHeight(Convert.ToInt32((VarStorage.Globals.otherFinalSize))) + " tall " + VarStorage.Globals.otherName;
            VarStorage.Globals.textLine3 = VarStorage.Globals.otherName + " looks to be " + conv.totalHeight(Convert.ToInt32(VarStorage.Globals.otherCompSize)) + " tall to " + VarStorage.Globals.mainName + ".";

            txtRecap.Text = VarStorage.Globals.textLine2;
            txtRecap.Text += Environment.NewLine;
            txtRecap.Text += VarStorage.Globals.textLine3;
            txtRecap.Text += Environment.NewLine;
            txtRecap.Text += "To " + VarStorage.Globals.mainName + ", the " + compObject + " looks to be " + conv.totalHeight(Convert.ToInt32((closest * 1828800) / Convert.ToInt32(VarStorage.Globals.mainFinalSize)));

            //Creates the VMS link.
            double p1in = VarStorage.Globals.player1Height;
            string p1HeightRounded = p1in.ToString("0");
            double p2in = VarStorage.Globals.player2Height;
            string p2HeightRounded = p2in.ToString("0");

            txtBFLink.Text = "http://vms.bigfurs.com/?chars=" + compObject + "+" + txtP1Name.Text + "[" + p1HeightRounded+ "um]+" + txtP2Name.Text + "[" + p2HeightRounded + "um]";

            txtDisplay.SelectionStart = txtDisplay.Text.Length; //Set the current caret position at the end
            txtDisplay.ScrollToCaret(); //Now scroll it automatically


            //Set the Height text fields.
            txtSize1.Text = conv.totalHeight(Convert.ToInt32(VarStorage.Globals.player1Height));
            txtSize2.Text = conv.totalHeight(Convert.ToInt32(VarStorage.Globals.player2Height));

        }

        private void btnCheckpoint_Click(object sender, EventArgs e)
        {
            txtStartP1.Text = Convert.ToString(VarStorage.Globals.player1Height);
            txtStartP2.Text = Convert.ToString(VarStorage.Globals.player2Height);
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            //File.WriteAllText(txtP1Name.Text + txtP2Name.Text + DateTime.Now.ToString("yyMMdd") + ".txt", txtDisplay.Text);
            Clash battleForm = new Clash();
            battleForm.Show();
        }
    }
}
