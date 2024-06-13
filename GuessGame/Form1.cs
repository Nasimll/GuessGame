using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            string level = comboBox1.SelectedItem.ToString();
            if(level == "Easy")
            {
                Class1.secLevel = 70;
            }
            else if(level == "Medium")
            {
                Class1.secLevel = 50;
            }
            else if (level == "Hard")
            {
                Class1.secLevel = 30;
            }
            else if(level == "Expert")
            {
                Class1.secLevel = 20;
            }

            Class1.minLevel= Convert.ToInt32(mintext.Text);
            Class1.maxLevel= Convert.ToInt32(maxtext.Text);
            //Class1.randMn = ranNum();

            Form2 form2 = new Form2();
            this.Hide();
            form2.ShowDialog();
            this.Close();

            /*public int ranNum()
            {
                Random ra = new Random();
                int ran = ra.Next(Level.minLevel, Level.maxLevel);
                return ran;

            }*/


        }

        private void btn2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
