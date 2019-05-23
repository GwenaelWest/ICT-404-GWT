using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Machine_à_calculer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float x = Convert.ToInt32(TextBoxX.Text);
            float y = Convert.ToInt32(TextBoxY.Text);

            if (radioButton1.Checked == true)
            {
                float resultat = x + y;
                lblResultat.Text = Convert.ToString (resultat);
            }
            else if (radioButton2.Checked == true)
            {
                float resultat = x - y;
                lblResultat.Text = Convert.ToString (resultat);
            }
            else if (radioButton3.Checked == true)
            {
                float resultat = x * y;
                lblResultat.Text = Convert.ToString (resultat);
            }
            else if (radioButton4.Checked == true)
            {
                float resultat = x / y;
                lblResultat.Text = Convert.ToString (resultat);
            }

        }
    }
}
