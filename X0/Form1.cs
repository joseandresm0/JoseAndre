using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace X0
{
    public partial class Form1 : Form
    {
        bool turn = true; // true = X turn; False = Y turn
        int turn_count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dennis es gay", "help");
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else
                b.Text = "0";
            turn = !turn;
            b.Enabled = false;
            turn_count++;
            checkforwinner();
        }
        private void checkforwinner()
        {
            bool There_is_awinner = false;
            if ((a1.Text == a2.Text) && (a2.Text == a3.Text) && (!a1.Enabled))
                There_is_awinner = true;
            else if ((b1.Text == b2.Text) && (b2.Text == b3.Text) && (!b1.Enabled))
                There_is_awinner = true;
            else if ((c1.Text == c2.Text) && (c2.Text == c3.Text) && (!c1.Enabled))
                There_is_awinner = true;


            else if ((a1.Text == b1.Text) && (b1.Text == c1.Text) && (!a1.Enabled))
                There_is_awinner = true;
            else if ((a2.Text == b2.Text) && (b2.Text == c2.Text) && (!a2.Enabled))
                There_is_awinner = true;
            else if ((a3.Text == b3.Text) && (b3.Text == c3.Text) && (!a3.Enabled))
                There_is_awinner = true;

           else if ((a1.Text == b2.Text) && (b2.Text == c3.Text) && (!a1.Enabled))
                There_is_awinner = true;
            else if ((a3.Text == b2.Text) && (b2.Text == c1.Text) && (!c1.Enabled))
                There_is_awinner = true;



            if (There_is_awinner)
            {
                disableButtons();

                string Winner = "";
                if (turn)
                    Winner = "0";
                else
                    Winner = "x";
                MessageBox.Show(Winner + "Congratulations", "winner");
            }
            else
            {
                if (turn_count == 9)
                MessageBox.Show("no one won", "Sorry");

            }
        }
        private void disableButtons()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;

                }
            } catch { }
        
              

            }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            turn_count = 0;
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";

                }
            }
            catch { }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

    

    
    


