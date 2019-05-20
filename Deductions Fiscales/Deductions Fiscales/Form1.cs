using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Titre: Deduction Fiscales 
// Auteur: Gwenael West
// Ver. 1.0
//Date: 16.05.19
namespace Deductions_Fiscales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Cursor.Current = txtBrut.Cursor;
        }

        private void btnCalcul_Click(object sender, EventArgs e)
        {
            double Revenu = 0;
            double Coefficient = 0;
            if (!double.TryParse(txtBrut.Text, out Revenu))
            {
                MessageBox.Show("Non et non pas de lettre juste des nombres !");
                
            }
            else
            {
                Revenu = Convert.ToDouble(txtBrut.Text);
            }
            if (!double.TryParse(txtCoefficient.Text, out Coefficient))
            {
                MessageBox.Show("Non et non pas de lettre juste des nombres !");
            }
            else
            {
                Coefficient = Convert.ToDouble(txtCoefficient.Text);
            }

            Revenu /= Coefficient;
            if (Check3.Checked == true)
            {
                double Fidelite = Convert.ToDouble(txtFidelite.Text); //Variable double de txtFidelite
                Revenu = Revenu - ( Fidelite/100*Revenu );
            }
            if (Check2.Checked == true)
            {
                double Transport = Convert.ToDouble(txtTransport.Text); //Variable double de txtTransport
                Revenu = Revenu - Transport;
            }
            if (Check1.Checked == true)
            {
                double Jeune = Convert.ToDouble(txtJeune.Text); //Variable double txtJeune
                Revenu = Revenu - Jeune;
            }
            lblImposable.Visible = true;
            lblImposable.Text = ( "Revenu imposable: " + Convert.ToString(Revenu));
            
     
        }

        private void lblImposable_Click(object sender, EventArgs e)
        {

        }
    }
}
