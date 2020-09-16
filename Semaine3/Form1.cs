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
        List<Etudiant> etudiants;
        public Form1()
        {
            InitializeComponent();
            etudiants = new List<Etudiant>();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            nbEtudiants++;
            Etudiant etudiant = new Etudiant(nom.Text, prenom.Text, nbEtudiants);
            richTextBox1.Text = etudiant.toString();
            etudiants.Add(etudiant);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Etudiant etudiant = new Etudiant(nom.Text, prenom.Text, nbEtudiants);
            etudiant.Nom = "Cloutier";
            MessageBox.Show(etudiant.Prenom + " " + etudiant.Nom + " numéro: " + etudiant.NoEtudiant);
        }

        private void radioButtonRouge_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBoutonRouge.Checked)
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
            string liste = string.Empty;
            foreach (object Item in listeNoix.CheckedItems)
            {
                liste += Item.ToString() + '\n';
            }
            MessageBox.Show(liste);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                this.BackColor = Color.Green;
            }

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                this.BackColor = Color.Blue;
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            var items = listeNoix.Items;
            items.Add("Noyer noir");
        }

        private void buttonChoix_Click(object sender, EventArgs e)
        {
            foreach (RadioButton radio in groupBox1.Controls.OfType<RadioButton>())
            {
                if (radio.Checked)
                {
                    MessageBox.Show("Le bouton suivant est coché : " + radio.Text);
                }
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox2.CheckState == CheckState.Checked) { 
                MessageBox.Show("Vous avez coché la boîte 2");
            }
            else
            {
                MessageBox.Show("Vous avez décoché la boîte 2");
            }
        }

        private void oui_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
