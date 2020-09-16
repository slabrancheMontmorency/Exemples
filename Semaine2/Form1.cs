using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semaine2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonFermer_Click(object sender, EventArgs e)
        {
            Application.Exit();
           // this.Close();
        }

        private void FormSemaine2_Load(object sender, EventArgs e)
        {
            this.ActiveControl = buttonFermer;

        }

        private void buttonFermer_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonEffacer_Click(object sender, EventArgs e)
        {
            textBoxUsager.Text = "";
            textBoxUsager.Clear();
        }

        private void buttonAfficher_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenue " + textBoxUsager.Text + " !",
                            "Message de bienvenue",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

            numericUpDown1.Value++;
        }

        private void textBoxUsager_TextChanged(object sender, EventArgs e)
        {

            if (textBoxUsager.Text == "" )
            {
                buttonAfficher.Enabled = false;
            }
            else
            {
                buttonAfficher.Enabled = true;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resultat = MessageBox.Show("Voulez-vous vraiment quitter? ", 
                                                    "Quitter", 
                                                    MessageBoxButtons.OKCancel, 
                                                    MessageBoxIcon.Warning);

            if(resultat == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}
