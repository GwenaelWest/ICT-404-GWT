using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Titre: Pizza
// Auteur: Gwenael West
// Ver. 1.0
//Date: 06.06.19
namespace Pizza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCommander_Click(object sender, EventArgs e)
        {
            string numtable = txtTable.Text;

            string pâtes = "";         //---- Liste variable pour ingrédients
            string anchois = "";
            string capres = "";
            string jambon = "";
            string crevettes = "";
        

            if (btnExtrafine.Checked == true)
            {
                pâtes = " pâte extra-fine avec \n";
            }
            if (btnfine.Checked == true)
            {
                pâtes = " pâte fine avec \n";
            }
            if (btnNormale.Checked == true)
            {
                pâtes = " pâte normale avec \n";
            }
            if  (btnEpaisse.Checked == true)
            {
                pâtes = " pâte epaisse avec \n";
            }
            if (btnAnchois.Checked == true)
            {
                anchois = " anchois,";
            }
            if (btnCapre.Checked == true)
            {
                capres = " capres,";
            }
            if (btnJambon.Checked == true)
            {
                jambon = " jambon,";
            }
            if (btnCrevettes.Checked == true)
            {
                crevettes = " crevettes,";
            }




            lblCommande.Visible = true;
            lblCommande.Text = ("Pour la " + numtable +":" + pâtes + anchois + capres + jambon + crevettes);


        }
    }
}
