using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semaine3
{
    public partial class Form1 : Form
    {
        private int nbEtudiants = 0;
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            nbEtudiants++;
            Etudiant etudiant = new Etudiant(nom.Text, prenom.Text, nbEtudiants);
            richTextBox1.Text = etudiant.toString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Etudiant etudiant = new Etudiant(nom.Text, prenom.Text, nbEtudiants);
            etudiant.Nom = "Cloutier";
            MessageBox.Show(etudiant.Prenom + " " + etudiant.Nom + " numéro: " + etudiant.NoEtudiant);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                this.BackColor = Color.Red;
            }
        }

        private void defaut_CheckedChanged(object sender, EventArgs e)
        {
            if (defaut.Checked)
            {
                
                this.BackColor = SystemColors.Control;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show(checkBox1.Checked.ToString());
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
      
            
        }
    }
}
