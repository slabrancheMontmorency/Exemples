using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diapos10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorDialog1.Color;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach(Button button in this.Controls.OfType<Button>())
                {
                    button.Font = fontDialog1.Font;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void button4_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            if (!openFileDialog1.CheckFileExists)
            {

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            if(!File.Exists(textBox1.Text)){
                MessageBox.Show("Fichier introuvable");
            }
            else
            {
                MessageBox.Show("Le fichier " + textBox1.Text + " a été trouvé dans le répertoire " + Directory.GetCurrentDirectory());
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string repertoire = Directory.GetCurrentDirectory();

            MessageBox.Show(repertoire);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string fichiers = "";
            foreach (string fichier in Directory.GetFiles(Directory.GetCurrentDirectory()))
            {
                fichiers += fichier + "\n";
            }
            MessageBox.Show(fichiers);
        }
    }
}
