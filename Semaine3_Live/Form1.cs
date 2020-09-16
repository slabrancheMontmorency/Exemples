using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semaine3_Live
{
    public partial class Form1 : Form
    {
        int nbEtudiants = 0;
        Etudiant[] etudiants;
        public Form1()
        {

            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.Size = new Size(100, 100);
          
            //Etudiant etudiant1 = new Etudiant();
            // Etudiant etudiant2 = new Etudiant("Sylvain", "Labranche", 1);
            etudiants = new Etudiant[10];

            radioButton4.Checked = true;

            checkBox3.Checked = true;

            checkedListBoxNoix.Items.Add("Noyer noir");
            checkedListBoxNoix.CheckOnClick = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "" && textBox2.Text!="")
            {
                nbEtudiants++;
                Etudiant etudiant = new Etudiant(textBox1.Text, textBox2.Text, nbEtudiants);
                richTextBox1.Text = etudiant.ToString();


                // etudiant.Prenom = "Steeve";
                // richTextBox1.Text += "\n" + etudiant.ToString();
                etudiants[nbEtudiants - 1] = etudiant;

            }
            else
            {
                MessageBox.Show("Manque d'information pour créer l'étudiant");
            }

           
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                this.BackColor = Color.Red;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                MessageBox.Show("Vous venez de cocher la case 1");
            }
            else
            {
                MessageBox.Show("Vous venez de décocher la case 1");
            }
        }

        private void buttonChoix_Click(object sender, EventArgs e)
        {
            int compteur = 0;
            foreach (RadioButton radio in groupBoxChoix.Controls.OfType<RadioButton>())
            {
                compteur++;
                if (radio.Checked)
                {
                    MessageBox.Show("Le bouton " + radio.Text + " est sélectionné." + compteur);
                }
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string liste = "";

            foreach(object item in checkedListBoxNoix.CheckedItems)
            {
                liste += item.ToString() + "\n";
            }
            MessageBox.Show("Vous avez coché : \n" + liste);
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
