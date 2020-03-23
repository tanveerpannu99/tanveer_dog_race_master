using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tanveer_dog_race_master
{
    public partial class Form1 : Form
    {
        int frst, scnd, thrd;
        String better1 ="";
        int runer1 = 0;

        private void Runner3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Runner Dog thrd is selected ");
            runer1 = 3;
            runner1.Enabled = false;
            runner2.Enabled = false;
            runner3.Enabled = false;
            runner4.Enabled = false;

        }

        public void resetPicture() {
            runner1.Enabled = true;
            runner4.Enabled = true;
            runner3.Enabled = true;
            runner2.Enabled = true;
            p1.Enabled = true;
            p2.Enabled = true;
            p3.Enabled = true;
            betAmount.Value = 0;
            better1 = "";
            runer1 = 0;
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            if (!better1.Equals("") && runer1 > 0)
            {
                if (betAmount.Value <= 50 && betAmount.Value <= frst && better1.Equals("Anny") && betAmount.Value>0) { Player1.Text = better1 + " choose Dog " + runer1 + " and " + betAmount.Value; button2.Enabled = true; resetPicture(); }

                else if (betAmount.Value <= 50 && betAmount.Value <= scnd && better1.Equals("Anu") && betAmount.Value > 0) { Player2.Text = better1 + " choose Dog " + runer1 + " and " + betAmount.Value; button2.Enabled = true; resetPicture(); }

                else if (betAmount.Value <= 50 && betAmount.Value <= thrd && better1.Equals("Anjali") && betAmount.Value > 0) { Player3.Text = better1 + " choose Dog " + runer1 + " and " + betAmount.Value; button2.Enabled = true; resetPicture(); }
                else { MessageBox.Show("Bet Amount Must be Greater then zero ");  }
            }
            else {
                MessageBox.Show("you have to choose atleast one player and one dog to participate ");

            }

          //  MessageBox.Show("" + betAmount.Value);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
            button1.Enabled = false;
            button2.Enabled = false;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            
            runner1.Left += Running.move();
            runner2.Left += Running.move();
            runner3.Left += Running.move();
            runner4.Left += Running.move();

            if (Running.pause(runner1.Left)==1) {
                timer1.Stop();
                MessageBox.Show("1st ");
                // if the player set the bet then the following code will set the budget 
                if (Player1.Text.ToString().Length > 10) { frst=Anny.winnner(Player1.Text.ToString(),frst,1);}
                if (Player2.Text.ToString().Length > 10) { scnd = Anu.winnner(Player2.Text.ToString(),scnd,1); }
                if (Player3.Text.ToString().Length > 10) { frst = Anjali.winnner(Player3.Text.ToString(),thrd, 1); }
                Player1.Text = "Anny";
                Player2.Text = "Anu";
                    Player3.Text = "Anjali";
              //  MessageBox.Show("" + frst + "--" + scnd + "--" + thrd);
            }
            if (Running.pause(runner2.Left) == 1)
            {
                timer1.Stop();
                MessageBox.Show("2nd");
                // if the player set the bet then the following code will set the budget 
                if (Player1.Text.ToString().Length > 10) { frst = Anny.winnner(Player1.Text.ToString(), frst, 2); }
                if (Player2.Text.ToString().Length > 10) { scnd = Anu.winnner(Player2.Text.ToString(), scnd, 2); }
                if (Player3.Text.ToString().Length > 10) { thrd= Anjali.winnner(Player3.Text.ToString(), thrd, 2); }
                Player1.Text = "Anny";
                Player2.Text = "Anu";
                Player3.Text = "Anjali";

              //  MessageBox.Show("" + frst + "--" + scnd + "--" + thrd);
            }

            if (Running.pause(runner3.Left) == 1)
            {
                timer1.Stop();
                MessageBox.Show("3rd");
                // if the player set the bet then the following code will set the budget 
                if (Player1.Text.ToString().Length > 10) { frst = Anny.winnner(Player1.Text.ToString(), frst, 3); }
                if (Player2.Text.ToString().Length > 10) { scnd = Anu.winnner(Player2.Text.ToString(), scnd, 3); }
                if (Player3.Text.ToString().Length > 10) { thrd = Anjali.winnner(Player3.Text.ToString(), thrd, 3); }
                Player1.Text = "Anny";
                Player2.Text = "Anu";
                Player3.Text = "Anjali";
               // MessageBox.Show("" + frst + "--" + scnd + "--" + thrd);
            }

            if (Running.pause(runner4.Left) == 1)
            {
                timer1.Stop();
                MessageBox.Show("4th ");
                // if the player set the bet then the following code will set the budget 
                if (Player1.Text.ToString().Length > 10) { frst = Anny.winnner(Player1.Text.ToString(), frst, 4); }
                if (Player2.Text.ToString().Length > 10) { scnd = Anu.winnner(Player2.Text.ToString(), scnd, 4); }
                if (Player3.Text.ToString().Length > 10) { frst = Anjali.winnner(Player3.Text.ToString(), thrd, 4); }
                Player1.Text = "Anny";
                Player2.Text = "Anu";
                Player3.Text = "Anjali";
               // MessageBox.Show("" + frst + "--" + scnd + "--" + thrd);
            }
            blance1.Text = "" + frst;
            balance2.Text = "" + scnd;
            balance3.Text = "" + thrd;

        }

        private void Runner4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Runner Dog Forth is selected ");
            runer1 =4;
            runner1.Enabled = false;
            runner2.Enabled = false;
            runner3.Enabled = false;
            runner4.Enabled = false;

        }

        private void Runner2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Runner Dog Second is selected ");
            runer1 = 2;
            runner1.Enabled = false;
            runner2.Enabled = false;
            runner3.Enabled = false;
            runner4.Enabled = false;

        }

        private void PictureBox6_Click(object sender, EventArgs e)
        {
            better1 = "Anu";
            MessageBox.Show("Your Budget is " + Punter.scndbetter(scnd));
            p1.Enabled = false;
            p2.Enabled = false;
            p3.Enabled = false;

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Runner Dog First is selected ");
            runer1 = 1;
            runner1.Enabled = false;
            runner2.Enabled = false;
            runner3.Enabled = false;
            runner4.Enabled = false;

        }

        private void P3_Click(object sender, EventArgs e)
        {
            better1 = "Anjali";
            MessageBox.Show("Your Budget is " + Punter.thrdbetter(thrd));
            p1.Enabled = false;
            p2.Enabled = false;
            p3.Enabled = false;

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            runner1.Left = 0;
            runner2.Left = 0;
            runner3.Left = 0;
            runner4.Left = 0;
            betAmount.Value = 0;
            resetPicture();
            Player1.Text = "Anny";
            Player2.Text = "Anu";
            Player3.Text = "Anjali";
            button1.Enabled = true;
            button2.Enabled = false;
        }

        private void Player1_Click(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void Player3_Click(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
            // pass the value from the static class to another class
            frst = Punter.frst;
            scnd = Punter.scnd;
            thrd = Punter.thrd;
            blance1.Text = "" + frst;
            balance2.Text = "" + scnd;
            balance3.Text = "" + thrd;
            MessageBox.Show("first of all select the player and then the dog by clicking on the picture of those ");


        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your Budget is "+ Punter.firstbetter(frst));
            p1.Enabled = false;
            p2.Enabled = false;
            p3.Enabled = false;

            better1 = "Anny";

        }

    }
}
