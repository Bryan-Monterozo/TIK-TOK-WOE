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

        bool player_Turn;

        //instead of using .Enabled for changing text forecolor
        bool enabler1;
        bool enabler2;
        bool enabler3;
        bool enabler4;
        bool enabler5;
        bool enabler6;
        bool enabler7;
        bool enabler8;
        bool enabler9;
        
        short add_Score;
        byte draw_Token = 0;
        bool win_Token; //to fix double winning pattern

        public mainForm()
        {
            InitializeComponent();
        }

        void Win_Condition()
        {
            // XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX

            if (button_Box_1.Text == "X" && button_Box_2.Text == "X" && button_Box_3.Text == "X" && win_Token == false)
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

                draw_Token = 0;
                win_Token = true;
                add_Score = short.Parse(player_X_Score.Text);
                player_X_Score.Text = Convert.ToString(add_Score + 1);
            }

            if (button_Box_4.Text == "X" && button_Box_5.Text == "X" && button_Box_6.Text == "X" && win_Token == false)
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
                draw_Token = 0;
                win_Token = true;
                add_Score = short.Parse(player_X_Score.Text);
                player_X_Score.Text = Convert.ToString(add_Score + 1);
            }

            if (button_Box_7.Text == "X" && button_Box_8.Text == "X" && button_Box_9.Text == "X" && win_Token == false)
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
                draw_Token = 0;
                win_Token = true;
                add_Score = short.Parse(player_X_Score.Text);
                player_X_Score.Text = Convert.ToString(add_Score + 1);
            }

            if (button_Box_1.Text == "X" && button_Box_4.Text == "X" && button_Box_7.Text == "X" && win_Token == false)
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
                draw_Token = 0;
                win_Token = true;
                add_Score = short.Parse(player_X_Score.Text);
                player_X_Score.Text = Convert.ToString(add_Score + 1);
            }

            if (button_Box_2.Text == "X" && button_Box_5.Text == "X" && button_Box_8.Text == "X" && win_Token == false)
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
                draw_Token = 0;
                win_Token = true;
                add_Score = short.Parse(player_X_Score.Text);
                player_X_Score.Text = Convert.ToString(add_Score + 1);
            }

            if (button_Box_3.Text == "X" && button_Box_6.Text == "X" && button_Box_9.Text == "X" && win_Token == false)
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
                draw_Token = 0;
                win_Token = true;
                add_Score = short.Parse(player_X_Score.Text);
                player_X_Score.Text = Convert.ToString(add_Score + 1);
            }

            if (button_Box_1.Text == "X" && button_Box_5.Text == "X" && button_Box_9.Text == "X" && win_Token == false)
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
                draw_Token = 0;
                win_Token = true;
                add_Score = short.Parse(player_X_Score.Text);
                player_X_Score.Text = Convert.ToString(add_Score + 1);
            }

            if (button_Box_3.Text == "X" && button_Box_5.Text == "X" && button_Box_7.Text == "X" && win_Token == false)
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
                draw_Token = 0;
                win_Token = true;
                add_Score = short.Parse(player_X_Score.Text);
                player_X_Score.Text = Convert.ToString(add_Score + 1);
            }

            // OOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO

            if (button_Box_1.Text == "O" && button_Box_2.Text == "O" && button_Box_3.Text == "O" && win_Token == false)
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
                draw_Token = 0;
                win_Token = true;
                add_Score = short.Parse(player_O_Score.Text);
                player_O_Score.Text = Convert.ToString(add_Score + 1);
            }

            if (button_Box_4.Text == "O" && button_Box_5.Text == "O" && button_Box_6.Text == "O" && win_Token == false)
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
                draw_Token = 0;
                win_Token = true;
                add_Score = short.Parse(player_O_Score.Text);
                player_O_Score.Text = Convert.ToString(add_Score + 1);
            }

            if (button_Box_7.Text == "O" && button_Box_8.Text == "O" && button_Box_9.Text == "O" && win_Token == false)
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
                draw_Token = 0;
                win_Token = true;
                add_Score = short.Parse(player_O_Score.Text);
                player_O_Score.Text = Convert.ToString(add_Score + 1);
            }

            if (button_Box_1.Text == "O" && button_Box_4.Text == "O" && button_Box_7.Text == "O" && win_Token == false)
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
                draw_Token = 0;
                win_Token = true;
                add_Score = short.Parse(player_O_Score.Text);
                player_O_Score.Text = Convert.ToString(add_Score + 1);
            }

            if (button_Box_2.Text == "O" && button_Box_5.Text == "O" && button_Box_8.Text == "O" && win_Token == false)
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
                draw_Token = 0;
                win_Token = true;
                add_Score = short.Parse(player_O_Score.Text);
                player_O_Score.Text = Convert.ToString(add_Score + 1);
            }

            if (button_Box_3.Text == "O" && button_Box_6.Text == "O" && button_Box_9.Text == "O" && win_Token == false)
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
                draw_Token = 0;
                win_Token = true;
                add_Score = short.Parse(player_O_Score.Text);
                player_O_Score.Text = Convert.ToString(add_Score + 1);
            }

            if (button_Box_1.Text == "O" && button_Box_5.Text == "O" && button_Box_9.Text == "O" && win_Token == false)
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
                draw_Token = 0;
                win_Token = true;
                add_Score = short.Parse(player_O_Score.Text);
                player_O_Score.Text = Convert.ToString(add_Score + 1);
            }

            if (button_Box_3.Text == "O" && button_Box_5.Text == "O" && button_Box_7.Text == "O" && win_Token == false)
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
                draw_Token = 0;
                win_Token = true;
                add_Score = short.Parse(player_O_Score.Text);
                player_O_Score.Text = Convert.ToString(add_Score + 1);
            }
        }

        void Draw_Condition()
        {
            if (draw_Token == 9)
            {
                MessageBox.Show("DRAW!!! -Gordon Ramsay probably", "TIK-TOK-WOE", MessageBoxButtons.OK);
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
        }

        private void reset_Button_Click(object sender, EventArgs e)
        {
            draw_Token = 0;
            win_Token = false;

            //button text
            button_Box_1.Text = "";
            button_Box_2.Text = "";
            button_Box_3.Text = "";
            button_Box_4.Text = "";
            button_Box_5.Text = "";
            button_Box_6.Text = "";
            button_Box_7.Text = "";
            button_Box_8.Text = "";
            button_Box_9.Text = "";

            //button enabler
            enabler1 = false;
            enabler2 = false;
            enabler3 = false;
            enabler4 = false;
            enabler5 = false;
            enabler6 = false;
            enabler7 = false;
            enabler8 = false;
            enabler9 = false;

            button_Box_1.Enabled = true;
            button_Box_2.Enabled = true;
            button_Box_3.Enabled = true;
            button_Box_4.Enabled = true;
            button_Box_5.Enabled = true;
            button_Box_6.Enabled = true;
            button_Box_7.Enabled = true;
            button_Box_8.Enabled = true;
            button_Box_9.Enabled = true;

            player_Turn = false;

            //button background button
            button_Box_1.BackColor = Color.White;
            button_Box_2.BackColor = Color.White;
            button_Box_3.BackColor = Color.White;
            button_Box_4.BackColor = Color.White;
            button_Box_5.BackColor = Color.White;
            button_Box_6.BackColor = Color.White;
            button_Box_7.BackColor = Color.White;
            button_Box_8.BackColor = Color.White;
            button_Box_9.BackColor = Color.White;
        }

        private void newgame_Button_Click(object sender, EventArgs e)
        {
            DialogResult new_Game_Confirm;
            new_Game_Confirm = MessageBox.Show("Do you want to start a New Game?", "Tik-Tok-Woe", MessageBoxButtons.YesNo);
            if (new_Game_Confirm == DialogResult.Yes)
            {
                draw_Token = 0;
                win_Token = false;

                //button text
                button_Box_1.Text = "";
                button_Box_2.Text = "";
                button_Box_3.Text = "";
                button_Box_4.Text = "";
                button_Box_5.Text = "";
                button_Box_6.Text = "";
                button_Box_7.Text = "";
                button_Box_8.Text = "";
                button_Box_9.Text = "";

                //button enabler
                enabler1 = false;
                enabler2 = false;
                enabler3 = false;
                enabler4 = false;
                enabler5 = false;
                enabler6 = false;
                enabler7 = false;
                enabler8 = false;
                enabler9 = false;

                button_Box_1.Enabled = true;
                button_Box_2.Enabled = true;
                button_Box_3.Enabled = true;
                button_Box_4.Enabled = true;
                button_Box_5.Enabled = true;
                button_Box_6.Enabled = true;
                button_Box_7.Enabled = true;
                button_Box_8.Enabled = true;
                button_Box_9.Enabled = true;

                player_Turn = false;

                //button background button
                button_Box_1.BackColor = Color.White;
                button_Box_2.BackColor = Color.White;
                button_Box_3.BackColor = Color.White;
                button_Box_4.BackColor = Color.White;
                button_Box_5.BackColor = Color.White;
                button_Box_6.BackColor = Color.White;
                button_Box_7.BackColor = Color.White;
                button_Box_8.BackColor = Color.White;
                button_Box_9.BackColor = Color.White;

                //score reset
                player_X_Score.Text = "0";
                player_O_Score.Text = "0";
            }
        }
    }
}
