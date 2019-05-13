using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Auteur: Gwenaël West - Date: 09.05.2019 - 
//Exercice "Bonjour Qui ?" ICT-404
namespace Bonjour
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdValider_Click(object sender, EventArgs e)
        {
            txt2.Text = ("Bonjour " + txt1.Text);
            // Appel la méthôôôôde quand on click sur le btn valider
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            cmdValider.Enabled = true;
            //méthode qui quand le nom est rentré le btn devient disponible
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            return ;
        }
    }
}
