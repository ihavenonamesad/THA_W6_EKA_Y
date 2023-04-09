using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THA_W6_EKA_Y
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            if (txt_many.Text == "")
            {
                MessageBox.Show("Please enter the amount of tries you want to guess");
            } 
            else
            {
                int b = Convert.ToInt32(txt_many.Text);
                if (b < 3)
                {
                    MessageBox.Show("Tries MUST be greater than 3");
                }
                else
                {
                    Form2 form2 = new Form2(b);
                    form2.ShowDialog();
                }
            }
        }

        private void txt_many_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar)&&!char.IsControl(e.KeyChar);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void lbl_title_Click(object sender, EventArgs e)
        {

        }

        private void lbl_how_Click(object sender, EventArgs e)
        {

        }
    }
}
