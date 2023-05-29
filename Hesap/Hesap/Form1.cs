using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesap
{
    public partial class Form1 : Form
    {
        double x, y;
        string islem;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if(txtSonuc.Text == "0")
            {
                txtSonuc.Text = "1";
            }
            else
            {
                txtSonuc.Text += "1";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if(txtSonuc.Text == "0")
            {
                txtSonuc.Text = "2";
            }
            else
            {
                txtSonuc.Text += "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if(txtSonuc.Text=="0")
            {
                txtSonuc.Text = "3";
            }
            else
            {
                txtSonuc.Text +="3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if(txtSonuc.Text == "0")
            {
                txtSonuc.Text="4";
            }
            else
            {
                txtSonuc.Text +="4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtSonuc.Text == "0")
            {
                txtSonuc.Text = "5";
            }
            else
            {
                txtSonuc.Text += "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtSonuc.Text == "0")
            {
                txtSonuc.Text = "6";
            }
            else
            {
                txtSonuc.Text += "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtSonuc.Text == "0")
            {
                txtSonuc.Text = "7";
            }
            else
            {
                txtSonuc.Text += "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtSonuc.Text == "0")
            {
                txtSonuc.Text = "8";
            }
            else
            {
                txtSonuc.Text += "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtSonuc.Text == "0")
            {
                txtSonuc.Text = "9";
            }
            else
            {
                txtSonuc.Text += "9";
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtSonuc.Text == "0")
            {
                txtSonuc.Text = "0";
            }
            else
            {
                txtSonuc.Text += "0";
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            if(Convert.ToDouble(txtSonuc.Text) >0)
            {
                txtSonuc.Text=txtSonuc.Text.Remove(txtSonuc.Text.Length -1,1);
            }
            if(txtSonuc.Text.Length==0)
            {
                txtSonuc.Text = "0";
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtSonuc.Text = "0";
            lblIslem.Text = "";
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            x=Convert.ToDouble(txtSonuc.Text);
            lblIslem.Text=txtSonuc.Text + "+";
            islem = "+";
            txtSonuc.Text = "0";
        }

        private void btnEksi_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(txtSonuc.Text);
            islem = "-"; 
            lblIslem.Text = txtSonuc.Text + "-";
            txtSonuc.Text = "0";
        }

        private void btnEsittir_Click(object sender, EventArgs e)
        {
            y = Convert.ToDouble(txtSonuc.Text);
            if(islem == "+")
            {
                txtSonuc.Text = Convert.ToString(x + y);
                lblIslem.Text = "";
            }
            if(islem == "-")
            {
                txtSonuc.Text = Convert.ToString(x - y);
                lblIslem.Text = "";
            }
            if(islem == "*")
            {
                txtSonuc.Text = Convert.ToString(x * y);
                lblIslem.Text = "";
            }
            if (islem == "/")
            {
                txtSonuc.Text = Convert.ToString(x / y);
                lblIslem.Text = "";
            }
            if (islem == "mod")
            {
                txtSonuc.Text = Convert.ToString(x % y);
                lblIslem.Text = "";
            }
        }

        private void btnCarp_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(txtSonuc.Text);
            islem = "*";
            lblIslem.Text = txtSonuc.Text + "*";
            txtSonuc.Text = "0";
        }

        private void btnBol_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(txtSonuc.Text);
            islem = "/";
            lblIslem.Text = txtSonuc.Text + "/";
            txtSonuc.Text = "0";
        }

        private void btnKare_Click(object sender, EventArgs e)
        {
            double kare = Convert.ToDouble(txtSonuc.Text);
            kare = Math.Pow(kare, 2);
            txtSonuc.Text = Convert.ToString(kare);
        }

        private void btnKesir_Click(object sender, EventArgs e)
        {
            double bolumx = Convert.ToDouble(txtSonuc.Text);
            bolumx = 1 / (bolumx);
            txtSonuc.Text = Convert.ToString(bolumx);
        }

        private void btnKök_Click(object sender, EventArgs e)
        {
            double karekok = Convert.ToDouble(txtSonuc.Text);
            karekok = Math.Sqrt(karekok);
            txtSonuc.Text = Convert.ToString(karekok);
        }

        private void btnYuzde_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(txtSonuc.Text);
            islem = "mod";
            lblIslem.Text = txtSonuc.Text + "(mod)";
            txtSonuc.Text = "0";
        }

        private void txtSonuc_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
