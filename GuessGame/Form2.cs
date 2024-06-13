using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessGame
{
    public partial class Form2 : Form
    {
        int proccesInit = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        int randomNumber;
        private void button1_Click(object sender, EventArgs e)
        {
            proccesInit++;
            if(proccesInit == 1)
            {
                button1.Text = "GUESS";
                timer1.Start();
                secondTime.Text = Class1.secLevel.ToString();
                randomNumber = randInd();

            }
            else if(proccesInit >= 2)
            {
                guessDes(randomNumber);
            }
        }
        private void secondTime_Click(object sender, EventArgs e)
        {
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            int x = 0;
            if(secondTime.Text != 0.ToString())
            {
                x = Convert.ToInt32(secondTime.Text) - 1;
            }
            else if (secondTime.Text == 0.ToString())
            {
                this.Close();
                timer1.Stop();
                MessageBox.Show("You Lost");
            }

            //secondTime.Text += 60.ToString();
            //int x = Convert.ToInt32(secondTime.Text);
            //int newx = x - 1;

            secondTime.Text = x.ToString();
        }
        private void guessDes(int randomNumber)
        {
                if (Convert.ToInt32(inputGuess.Text) == randomNumber)
                {
                    MessageBox.Show("You WON Iuuuyw");
                    this.Close();
                }
                else if (Convert.ToInt32(inputGuess.Text) > randomNumber)
                {
                    label2.Text = "Try Lower!";
                }
                else if (Convert.ToInt32(inputGuess.Text) < randomNumber)
                {
                    label2.Text = "Try Higher!";
                }
        }

        private int randInd()
        {
            Random rnd = new Random();
            int rand = rnd.Next(Class1.minLevel, Class1.maxLevel);
            return rand;

        }


    }
}
