using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semaine4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAjoutObjet_Click(object sender, EventArgs e)
        {
            int nbObjets = listBoxObjets.Items.Count;
            listBoxObjets.Items.Add("Objet" + ++nbObjets);
            comboBox1.Items.Add("Objet" + ++nbObjets);
        }

        private void buttonEnlever_Click(object sender, EventArgs e)
        {
            if (listBoxObjets.Items.Count >= 1)
            {
                listBoxObjets.Items.RemoveAt(listBoxObjets.Items.Count - 1);
                comboBox1.Items.RemoveAt(comboBox1.Items.Count - 1);
            }
        }

        private void buttonAfficher_Click(object sender, EventArgs e)
        {
            string selection = "";
            foreach(object item in listBoxObjets.SelectedItems)
            {
                selection += item.ToString() + '\n';
            }

            MessageBox.Show(selection, "Items choisi");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBoxObjets.SelectionMode = SelectionMode.MultiExtended;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void buttonChercher_Click(object sender, EventArgs e)
        {
            if (listBoxObjets.Items.Contains(textBoxObjet.Text)) {
                MessageBox.Show(textBoxObjet.Text + " est contenu dans la liste.");
            }
            else
            {
                MessageBox.Show(textBoxObjet.Text + " n'est pas contenu dans la liste.");
            }
        }

        private void buttonForcer_Click(object sender, EventArgs e)
        {
            int index = listBoxObjets.Items.IndexOf(textBoxObjet.Text);
            if (index >= 0)
            {
                listBoxObjets.SetSelected(index, true);
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
