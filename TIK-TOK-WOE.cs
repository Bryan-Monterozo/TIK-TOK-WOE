using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TIK_TOK_WOE
{
    public partial class mainForm : Form
    {
        //Assigning Variables

        Boolean player_Turn;

        //instead of using .Enabled for changing text forecolor
        Boolean enabler1;
        Boolean enabler2;
        Boolean enabler3;
        Boolean enabler4;
        Boolean enabler5;
        Boolean enabler6;
        Boolean enabler7;
        Boolean enabler8;
        Boolean enabler9;
        
        int add;
        byte draw_Token = 0;

        public mainForm()
        {
            InitializeComponent();
        }

        /*
                void Enabler()
                {
                    button_Box_1.Enabled = false;
                    button_Box_2.Enabled = false;
                    button_Box_3.Enabled = false;
                    button_Box_4.Enabled = false;
                    button_Box_5.Enabled = false;
                    button_Box_6.Enabled = false;
                    button_Box_7.Enabled = false;
                    button_Box_8.Enabled = false;
                    button_Box_9.Enabled = false;
                }
        */

        void Win_Condition()
        {
            // XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX

            if (button_Box_1.Text == "X" && button_Box_2.Text == "X" && button_Box_3.Text == "X")
            {
                button_Box_1.BackColor = Color.Green;
                button_Box_2.BackColor = Color.Green;
                button_Box_3.BackColor = Color.Green;

                MessageBox.Show("Player X is DOMINATING!!", "TIK-TOK-WOE", MessageBoxButtons.OK);
                button_Box_4.Enabled = false;
                button_Box_5.Enabled = false;
                button_Box_6.Enabled = false;

                button_Box_7.Enabled = false;
                button_Box_8.Enabled = false;
                button_Box_9.Enabled = false;
            }

            if (button_Box_4.Text == "X" && button_Box_5.Text == "X" && button_Box_6.Text == "X")
            {
                button_Box_4.BackColor = Color.Green;
                button_Box_5.BackColor = Color.Green;
                button_Box_6.BackColor = Color.Green;

                MessageBox.Show("Player X is DOMINATING!!", "TIK-TOK-WOE", MessageBoxButtons.OK);
                button_Box_1.Enabled = false;
                button_Box_2.Enabled = false;
                button_Box_3.Enabled = false;

                button_Box_7.Enabled = false;
                button_Box_8.Enabled = false;
                button_Box_9.Enabled = false;
            }

            if (button_Box_7.Text == "X" && button_Box_8.Text == "X" && button_Box_9.Text == "X")
            {
                button_Box_7.BackColor = Color.Green;
                button_Box_8.BackColor = Color.Green;
                button_Box_9.BackColor = Color.Green;

                MessageBox.Show("Player X is DOMINATING!!", "TIK-TOK-WOE", MessageBoxButtons.OK);
                button_Box_4.Enabled = false;
                button_Box_5.Enabled = false;
                button_Box_6.Enabled = false;

                button_Box_1.Enabled = false;
                button_Box_2.Enabled = false;
                button_Box_3.Enabled = false;
            }

            if (button_Box_1.Text == "X" && button_Box_4.Text == "X" && button_Box_7.Text == "X")
            {
                button_Box_1.BackColor = Color.Green;
                button_Box_4.BackColor = Color.Green;
                button_Box_7.BackColor = Color.Green;

                MessageBox.Show("Player X is DOMINATING!!", "TIK-TOK-WOE", MessageBoxButtons.OK);
                button_Box_2.Enabled = false;
                button_Box_5.Enabled = false;
                button_Box_8.Enabled = false;

                button_Box_3.Enabled = false;
                button_Box_6.Enabled = false;
                button_Box_9.Enabled = false;
            }

            if (button_Box_2.Text == "X" && button_Box_5.Text == "X" && button_Box_8.Text == "X")
            {
                button_Box_2.BackColor = Color.Green;
                button_Box_5.BackColor = Color.Green;
                button_Box_8.BackColor = Color.Green;

                MessageBox.Show("Player X is DOMINATING!!", "TIK-TOK-WOE", MessageBoxButtons.OK);
                button_Box_1.Enabled = false;
                button_Box_4.Enabled = false;
                button_Box_7.Enabled = false;

                button_Box_3.Enabled = false;
                button_Box_6.Enabled = false;
                button_Box_9.Enabled = false;
            }

            if (button_Box_3.Text == "X" && button_Box_6.Text == "X" && button_Box_9.Text == "X")
            {
                button_Box_3.BackColor = Color.Green;
                button_Box_6.BackColor = Color.Green;
                button_Box_9.BackColor = Color.Green;

                MessageBox.Show("Player X is DOMINATING!!", "TIK-TOK-WOE", MessageBoxButtons.OK);
                button_Box_2.Enabled = false;
                button_Box_5.Enabled = false;
                button_Box_8.Enabled = false;

                button_Box_1.Enabled = false;
                button_Box_4.Enabled = false;
                button_Box_7.Enabled = false;
            }

            if (button_Box_1.Text == "X" && button_Box_5.Text == "X" && button_Box_9.Text == "X")
            {
                button_Box_1.BackColor = Color.Green;
                button_Box_5.BackColor = Color.Green;
                button_Box_9.BackColor = Color.Green;

                MessageBox.Show("Player X is DOMINATING!!", "TIK-TOK-WOE", MessageBoxButtons.OK);
                button_Box_2.Enabled = false;
                button_Box_3.Enabled = false;
                button_Box_4.Enabled = false;

                button_Box_6.Enabled = false;
                button_Box_7.Enabled = false;
                button_Box_8.Enabled = false;
            }

            if (button_Box_3.Text == "X" && button_Box_5.Text == "X" && button_Box_7.Text == "X")
            {
                button_Box_3.BackColor = Color.Green;
                button_Box_5.BackColor = Color.Green;
                button_Box_7.BackColor = Color.Green;

                MessageBox.Show("Player X is DOMINATING!!", "TIK-TOK-WOE", MessageBoxButtons.OK);
                button_Box_2.Enabled = false;
                button_Box_1.Enabled = false;
                button_Box_4.Enabled = false;

                button_Box_6.Enabled = false;
                button_Box_9.Enabled = false;
                button_Box_8.Enabled = false;
            }

            // OOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO

            if (button_Box_1.Text == "O" && button_Box_2.Text == "O" && button_Box_3.Text == "O")
            {
                button_Box_1.BackColor = Color.Red;
                button_Box_2.BackColor = Color.Red;
                button_Box_3.BackColor = Color.Red;

                MessageBox.Show("Player O is DOMINATING!!", "TIK-TOK-WOE", MessageBoxButtons.OK);
                button_Box_4.Enabled = false;
                button_Box_5.Enabled = false;
                button_Box_6.Enabled = false;

                button_Box_7.Enabled = false;
                button_Box_8.Enabled = false;
                button_Box_9.Enabled = false;
            }

            if (button_Box_4.Text == "O" && button_Box_5.Text == "O" && button_Box_6.Text == "O")
            {
                button_Box_4.BackColor = Color.Red;
                button_Box_5.BackColor = Color.Red;
                button_Box_6.BackColor = Color.Red;

                MessageBox.Show("Player O is DOMINATING!!", "TIK-TOK-WOE", MessageBoxButtons.OK);
                button_Box_1.Enabled = false;
                button_Box_2.Enabled = false;
                button_Box_3.Enabled = false;

                button_Box_7.Enabled = false;
                button_Box_8.Enabled = false;
                button_Box_9.Enabled = false;
            }

            if (button_Box_7.Text == "O" && button_Box_8.Text == "O" && button_Box_9.Text == "O")
            {
                button_Box_7.BackColor = Color.Red;
                button_Box_8.BackColor = Color.Red;
                button_Box_9.BackColor = Color.Red;

                MessageBox.Show("Player O is DOMINATING!!", "TIK-TOK-WOE", MessageBoxButtons.OK);
                button_Box_4.Enabled = false;
                button_Box_5.Enabled = false;
                button_Box_6.Enabled = false;

                button_Box_1.Enabled = false;
                button_Box_2.Enabled = false;
                button_Box_3.Enabled = false;
            }

            if (button_Box_1.Text == "O" && button_Box_4.Text == "O" && button_Box_7.Text == "O")
            {
                button_Box_1.BackColor = Color.Red;
                button_Box_4.BackColor = Color.Red;
                button_Box_7.BackColor = Color.Red;

                MessageBox.Show("Player O is DOMINATING!!", "TIK-TOK-WOE", MessageBoxButtons.OK);
                button_Box_2.Enabled = false;
                button_Box_5.Enabled = false;
                button_Box_8.Enabled = false;

                button_Box_3.Enabled = false;
                button_Box_6.Enabled = false;
                button_Box_9.Enabled = false;
            }

            if (button_Box_2.Text == "O" && button_Box_5.Text == "O" && button_Box_8.Text == "O")
            {
                button_Box_2.BackColor = Color.Red;
                button_Box_5.BackColor = Color.Red;
                button_Box_8.BackColor = Color.Red;

                MessageBox.Show("Player O is DOMINATING!!", "TIK-TOK-WOE", MessageBoxButtons.OK);
                button_Box_1.Enabled = false;
                button_Box_4.Enabled = false;
                button_Box_7.Enabled = false;

                button_Box_3.Enabled = false;
                button_Box_6.Enabled = false;
                button_Box_9.Enabled = false;
            }

            if (button_Box_3.Text == "O" && button_Box_6.Text == "O" && button_Box_9.Text == "O")
            {
                button_Box_3.BackColor = Color.Red;
                button_Box_6.BackColor = Color.Red;
                button_Box_9.BackColor = Color.Red;

                MessageBox.Show("Player O is DOMINATING!!", "TIK-TOK-WOE", MessageBoxButtons.OK);
                button_Box_2.Enabled = false;
                button_Box_5.Enabled = false;
                button_Box_8.Enabled = false;

                button_Box_1.Enabled = false;
                button_Box_4.Enabled = false;
                button_Box_7.Enabled = false;
            }

            if (button_Box_1.Text == "O" && button_Box_5.Text == "O" && button_Box_9.Text == "O")
            {
                button_Box_1.BackColor = Color.Red;
                button_Box_5.BackColor = Color.Red;
                button_Box_9.BackColor = Color.Red;

                MessageBox.Show("Player O is DOMINATING!!", "TIK-TOK-WOE", MessageBoxButtons.OK);
                button_Box_2.Enabled = false;
                button_Box_3.Enabled = false;
                button_Box_4.Enabled = false;

                button_Box_6.Enabled = false;
                button_Box_7.Enabled = false;
                button_Box_8.Enabled = false;
            }

            if (button_Box_3.Text == "O" && button_Box_5.Text == "O" && button_Box_7.Text == "O")
            {
                button_Box_3.BackColor = Color.Red;
                button_Box_5.BackColor = Color.Red;
                button_Box_7.BackColor = Color.Red;

                MessageBox.Show("Player O is DOMINATING!!", "TIK-TOK-WOE", MessageBoxButtons.OK);
                button_Box_2.Enabled = false;
                button_Box_1.Enabled = false;
                button_Box_4.Enabled = false;

                button_Box_6.Enabled = false;
                button_Box_9.Enabled = false;
                button_Box_8.Enabled = false;
            }
        }

        void Draw_Condition()
        {
            if (draw_Token == 9)
            {
                MessageBox.Show("Gordon Ramsay shouted, DRAW!!!", "TIK-TOK-WOE", MessageBoxButtons.OK);
                button_Box_1.Enabled = false;
                button_Box_2.Enabled = false;
                button_Box_3.Enabled = false;
                button_Box_4.Enabled = false;
                button_Box_5.Enabled = false;
                button_Box_6.Enabled = false;
                button_Box_7.Enabled = false;
                button_Box_8.Enabled = false;
                button_Box_9.Enabled = false;
            }

        }

        private void button_Box_1_Click(object sender, EventArgs e)
        {
            if (enabler1 == false)
            {
                if (player_Turn == false)
                {
                    button_Box_1.Text = "X";
                    player_Turn = true;
                    button_Box_1.ForeColor = Color.Red;
                }
                else
                {
                    button_Box_1.Text = "O";
                    player_Turn = false;
                    button_Box_1.ForeColor = Color.Green;
                }
                Win_Condition();
                draw_Token = (byte)(draw_Token + 1);
                Draw_Condition();
            }
            enabler1 = true;
            
            

            //button_Box_1.Enabled = false;
        }

        private void button_Box_2_Click(object sender, EventArgs e)
        {
            if (enabler2 == false)
            {
                if (player_Turn == false)
                {
                    button_Box_2.Text = "X";
                    player_Turn = true;
                    button_Box_2.ForeColor = Color.Red;
                }
                else
                {
                    button_Box_2.Text = "O";
                    player_Turn = false;
                    button_Box_2.ForeColor = Color.Green;
                }
                Win_Condition();
                draw_Token = (byte)(draw_Token + 1);
                Draw_Condition();
            }
            enabler2 = true;
            //button_Box_3.Enabled = false;
        }

        private void button_Box_3_Click(object sender, EventArgs e)
        {
            if (enabler3 == false)
            {
                if (player_Turn == false)
                {
                    button_Box_3.Text = "X";
                    player_Turn = true;
                    button_Box_3.ForeColor = Color.Red;
                }
                else
                {
                    button_Box_3.Text = "O";
                    player_Turn = false;
                    button_Box_3.ForeColor = Color.Green;
                }
                Win_Condition();
                draw_Token = (byte)(draw_Token + 1);
                Draw_Condition();
            }
            enabler3 = true;
            //button_Box_3.Enabled = false;
        }

        private void button_Box_4_Click(object sender, EventArgs e)
        {
            if (enabler4 == false)
            {
                if (player_Turn == false)
                {
                    button_Box_4.Text = "X";
                    player_Turn = true;
                    button_Box_4.ForeColor = Color.Red;
                }
                else
                {
                    button_Box_4.Text = "O";
                    player_Turn = false;
                    button_Box_4.ForeColor = Color.Green;
                }
                Win_Condition();
                draw_Token = (byte)(draw_Token + 1);
                Draw_Condition();
            }
            enabler4 = true;
            // button_Box_4.Enabled = false;
        }

        private void button_Box_5_Click(object sender, EventArgs e)
        {
            if (enabler5 == false)
            {
                if (player_Turn == false)
                {
                    button_Box_5.Text = "X";
                    player_Turn = true;
                    button_Box_5.ForeColor = Color.Red;
                }
                else
                {
                    button_Box_5.Text = "O";
                    player_Turn = false;
                    button_Box_5.ForeColor = Color.Green;
                }
                Win_Condition();
                draw_Token = (byte)(draw_Token + 1);
                Draw_Condition();
            }
            enabler5 = true;
            // button_Box_5.Enabled = false;
        }

        private void button_Box_6_Click(object sender, EventArgs e)
        {
            if (enabler6 == false)
            {
                if (player_Turn == false)
                {
                    button_Box_6.Text = "X";
                    player_Turn = true;
                    button_Box_6.ForeColor = Color.Red;
                }
                else
                {
                    button_Box_6.Text = "O";
                    player_Turn = false;
                    button_Box_6.ForeColor = Color.Green;
                }
                Win_Condition();
                draw_Token = (byte)(draw_Token + 1);
                Draw_Condition();
            }
            enabler6 = true;
            //  button_Box_6.Enabled = false;
        }

        private void button_Box_7_Click(object sender, EventArgs e)
        {
            if (enabler7 == false)
            {
                if (player_Turn == false)
                {
                    button_Box_7.Text = "X";
                    player_Turn = true;
                    button_Box_7.ForeColor = Color.Red;
                }
                else
                {
                    button_Box_7.Text = "O";
                    player_Turn = false;
                    button_Box_7.ForeColor = Color.Green;
                }
                Win_Condition();
                draw_Token = (byte)(draw_Token + 1);
                Draw_Condition();
            }
            enabler7 = true;
            //   button_Box_7.Enabled = false;
        }

        private void button_Box_8_Click(object sender, EventArgs e)
        {
            if (enabler8 == false)
            {
                if (player_Turn == false)
                {
                    button_Box_8.Text = "X";
                    player_Turn = true;
                    button_Box_8.ForeColor = Color.Red;
                }
                else
                {
                    button_Box_8.Text = "O";
                    player_Turn = false;
                    button_Box_8.ForeColor = Color.Green;
                }
                Win_Condition();
                draw_Token = (byte)(draw_Token + 1);
                Draw_Condition();
            }
            enabler8 = true;
            //  button_Box_8.Enabled = false;
        }

        private void button_Box_9_Click(object sender, EventArgs e)
        {
            if (enabler9 == false)
            {
                if (player_Turn == false)
                {
                    button_Box_9.Text = "X";
                    player_Turn = true;
                    button_Box_9.ForeColor = Color.Red;
                }
                else
                {
                    button_Box_9.Text = "O";
                    player_Turn = false;
                    button_Box_9.ForeColor = Color.Green;
                }
                Win_Condition();
                draw_Token = (byte)(draw_Token + 1);
                Draw_Condition();
            }
            enabler9 = true;
            //   button_Box_9.Enabled = false;
        }

    }
}
