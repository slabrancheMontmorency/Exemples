using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semaine4_2
{
    public partial class Form1 : Form
    {

        string[] circonscription = new string[2] { "Vimont", "Fabre" };
        string[] candidatsC1 = new string[4] { "Jean Rousselle", "Michel Reeves", "Sylvie Moreau", "Caroline Trottier-gascon" };
        string[] candidatsC2 = new string[4] { "Monique Sauvé", "Adrina Dudas", "Odette Lavigne", "Nora Yota" };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            comboBoxElection.Items.AddRange(circonscription);

        }

        private void comboBoxElection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxElection.SelectedIndex == 0)
            {
                listBoxCandidats.Items.Clear();
                listBoxCandidats.Items.AddRange(candidatsC1);
            }else if (comboBoxElection.SelectedIndex == 1)
            {
                listBoxCandidats.Items.Clear();
                listBoxCandidats.Items.AddRange(candidatsC2);
            }
        }
    }
}
