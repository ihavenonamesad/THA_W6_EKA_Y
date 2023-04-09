using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace THA_W6_EKA_Y
{
    public partial class Form2 : Form
    {
        string answer = "";
        string guess="";
        int lines;
        int x = 0;
        int wincounter = 0;
        string[] green = { "", "", "", "", "" };
        //List<string> wordlist = 
        string[] wordlist = File.ReadAllText("Wordle Word List.txt").Split(',');

        public Form2(int a)
        {
            InitializeComponent();
            x = a;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            for (int i=0;i<5;i++)
            {
                for (int j = 0; j < x; j++)
                {
                    Button button = new Button();
                    button.Enabled = true;
                    button.Size = new Size(50, 50);
                    button.Location = new Point(40 + (50 * i), 70+(50*j));
                    button.Tag = j.ToString() + "," + i.ToString();
                    button.Click += (ButtonClick);
                    this.Controls.Add(button);
                }
            }
            Answer();
        }
        private void ButtonClick (object sender, EventArgs e)
        {
            Button btn = sender as Button;
            //MessageBox.Show(btn.Tag.ToString());
            //MessageBox.Show(answer);
             
        }
        private void Answer()
        {
            for(int i = 0; i < wordlist.Length;i++)
            {
                wordlist[i] = wordlist[i].ToString().ToUpper();
            }
            Random rnd = new Random();
            answer = wordlist[rnd.Next(0, wordlist.Length - 1)].ToUpper();
            //answer = "APPLE";
        }
        private void update(string key)
        {
            if (key == "enter")
            {
                string a = guess.ToUpper();
                if (wordlist.Contains(a))
                {
                    CheckGreen();
                    checkyellow();
                    Winner();
                }
                else 
                {
                    MessageBox.Show("not a word");
                }
            } else if (key == "delete")
            {
                deletebutton(guess.Length);
            }
            else
            {
                if (guess.Length == 5)
                {

                }
                else
                {
                    guess = guess + key;
                }
                updatewordinbuttons(guess.Length);
            }
        }
       
        private void updatewordinbuttons(int word)
        {
            for (int i = 0; i < 5; i++)
            {
                foreach(Button b in this.Controls.OfType<Button>())
                {
                    string index = b.Tag.ToString();
                    if (index == lines.ToString()+"," + i.ToString()&&i<word)
                    { 
                        b.Text = guess[i].ToString();
                    }
                    else if(index== lines.ToString() + "," + i.ToString())
                    {
                        b.Text = "";
                    }
                }
            }
        }
       
        private void deletebutton(int word)
        {
            if (guess.Length == 0) {

            }
            else
            {
                guess = guess.Substring(0, guess.Length - 1);
                updatewordinbuttons(guess.Length);
            }
        }
       
        private void CheckGreen()
        {
            wincounter = 0;
            for (int i = 0; i < 5; i++)
            {
                foreach ( Button btn in Controls.OfType<Button>())
                {
                    string index = btn.Tag.ToString();
                    if (index == lines.ToString() + "," + i.ToString())
                    {
                        
                        if (guess[i] == answer[i] && guess.Length>=5)
                        {
                            btn.BackColor = Color.LimeGreen;
                            green[i] = "Yes";
                            wincounter++;
                        }
                        else
                        {
                            green[i] = "";
                        }
                    }
                }
            } 
        }
        private void checkyellow()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int k = 0; k < 5; k++)
                {
                    foreach (Button btn in this.Controls.OfType<Button>())
                    {
                        string index = btn.Tag.ToString();
                        if (index == lines.ToString() + "," + i.ToString())
                        {
                            if (guess.Length < 5) { }
                            else if (green[k] =="" && answer[k] == guess[i] && btn.BackColor != Color.LimeGreen)
                            {
                                btn.BackColor = Color.Yellow;
                            }
                        }
                    }
                }
            }
        }
        private void Winner()
        {
            guess = "";
            lines++;
            if (wincounter == 5)
            {
                MessageBox.Show("YOU WIN!!!");
            } 
            else if (wincounter < 5 && lines == x)
            {
                MessageBox.Show("YOU LOSE!!! the word is "+answer);
            }
        }
        
        
        private void btn_p_Click(object sender, EventArgs e)
        {
            update("P");
        }
        private void btn_Q_Click(object sender, EventArgs e)
        {
            update("Q");
        }
        private void btn_W_Click(object sender, EventArgs e)
        {
            update("W");
        }
        private void btn_E_Click(object sender, EventArgs e)
        {
            update("E");
        }
        private void btn_R_Click(object sender, EventArgs e)
        {
            update("R");
        }
        private void btn_T_Click(object sender, EventArgs e)
        {
            update("T");
        }
        private void btn_Y_Click(object sender, EventArgs e)
        {
            update("Y");
        }
        private void btn_u_Click(object sender, EventArgs e)
        {
            update("U");
        }
        private void btn_i_Click(object sender, EventArgs e)
        {
            update("I");
        }
        private void btn_o_Click(object sender, EventArgs e)
        {
            update("O");
        }
        private void btn_A_Click(object sender, EventArgs e)
        {
            update("A");
        }
        private void btn_S_Click(object sender, EventArgs e)
        {
            update("S");
        }
        private void btn_D_Click(object sender, EventArgs e)
        {
            update("D");
        }
        private void btn_F_Click(object sender, EventArgs e)
        {
            update("F");
        }
        private void btn_GZ_Click(object sender, EventArgs e)
        {
            update("G");
        }
        private void btn_H_Click(object sender, EventArgs e)
        {
            update("H");
        }
        private void btn_J_Click(object sender, EventArgs e)
        {
            update("J");
        }
        private void btn_K_Click(object sender, EventArgs e)
        {
            update("K");
        }
        private void btn_L_Click(object sender, EventArgs e)
        {
            update("L");
        }
        private void btn_Z_Click(object sender, EventArgs e)
        {
            update("Z");
        }
        private void btn_X_Click(object sender, EventArgs e)
        {
            update("X");
        }
        private void btn_C_Click(object sender, EventArgs e)
        {
            update("C");
        }
        private void btn_V_Click(object sender, EventArgs e)
        {
            update("V");
        }
        private void btn_B_Click(object sender, EventArgs e)
        {
            update("B");
        }
        private void btn_N_Click(object sender, EventArgs e)
        {
            update("N");
        }
        private void btn_M_Click(object sender, EventArgs e)
        {
            update("M");
        }
        private void btn_Del_Click(object sender, EventArgs e)
        {
            update("delete");
        }
        private void btn_Enter_Click(object sender, EventArgs e)
        {
            if (guess.Length < 5) {
                MessageBox.Show("Must be 5 letters");
            }
            else
            {
                update("enter");
            }
        }
    }
}
