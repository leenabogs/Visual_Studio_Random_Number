using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random_example
{
    public partial class Form1 : Form
    {
        int m;
        int raha;
        public Form1()
        {
           
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {
            
            m = 0;
            raha = 0;
            lblKatse.Text = Convert.ToString(m);
            lblRand.Text = "";

            ok.Enabled = true;
            start.Enabled = false;
            Pilt.Image = pilt3.Image;
            lblKirjeldus.Text = "";
            lblKirjeldus.Visible = false;
            ok.Focus();
        

        }

        private void ok_Click(object sender, EventArgs e)
        {
            int k;
            Random rand = new Random();
            k = rand.Next(0, 11);
            raha++;
            lblRand.Text = Convert.ToString(k);
            m = Convert.ToInt32(lblKatse.Text);
            m++;
            lblKatse.Text = Convert.ToString(m);

            // stop
            if (k == 0 || k == 10)
            {
                ok.Enabled = false;
                start.Enabled = true;
                lblKirjeldus.Visible = true; // сообщение
                if (m> 10)
                {
                    Pilt.Image = pilt1.Image;
                    lblKirjeldus.Text = "Попыток больше, чем 10. Заплатили" + Convert.ToString(raha) + "евро";

                }
                else if (m < 10)
                {
                    Pilt.Image = pilt2.Image;
                    lblKirjeldus.Text = "Попыток меньше, чем 10. Заплатили" + Convert.ToString(raha) + "евро";

                }
                else
                {
                    Pilt.Image = pilt1.Image;
                    lblKirjeldus.Text = "Попыток точно 10. Заплати" + Convert.ToString(raha) + "евро";

                }
            }
        }
    }
}
