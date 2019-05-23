using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fenêtre_Bleue_Rouge
    //Auteur: Gwenael West  Fenêtre Bleue & Rouge
    //Date: 23.05.19   Ver. 1.0

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int compteurcouleur = 0;
        int compteurdeplacement = 0;

        private void BtnBleu_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
            compteurcouleur++;
        }

        private void BtnRouge_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
            compteurcouleur++;
        }

        private void BtnHautGauche_Click(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
            compteurdeplacement++;
        }

        private void BtnHautDroite_Click(object sender, EventArgs e)
        {
            this.Location = new Point(1450, 0);
            compteurdeplacement++;
        }

        private void BtnBasGauche_Click(object sender, EventArgs e)
        {
            this.Location = new Point(0, 550);
            compteurdeplacement++;
        }

        private void BtnBasDroite_Click(object sender, EventArgs e)
        {
            this.Location = new Point(1450, 550);
            compteurdeplacement++;            
        }

        private void BtnStats_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(compteurdeplacement) + " déplacement(s) et " + Convert.ToString(compteurcouleur) + " de couleurs ");
        }

        private void BtnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
