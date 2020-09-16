using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semaine5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            helpProvider1.SetShowHelp(button1, true);
            helpProvider1.SetHelpString(button1, "Faites attention à vous!");
            helpProvider1.SetShowHelp(button2, true);
            helpProvider1.SetHelpString(button2, "Ce bouton effectuera la validation des données");

            ToolTip toolTip1 = new ToolTip();
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(button1, "Cliquez à vos risques et périls"); 


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            /*
            try
            {
                Console.WriteLine("Entrez un nombre : ");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine("100/" + n + "=" + 100 / n);
            } catch (DivideByZeroException dbex)
            {
                Console.Error.WriteLine("Exception attrapée: division par zéro");
            } catch(Exception ex)
            {
                Console.Error.WriteLine("Une autre exception est survenue");
            }
            finally
            {
                Console.WriteLine("Quel que soit le résultat, ceci est affiché");
            }
            */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError(button1, "Vous n'auriez pas du me cliquer!!!!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "" && textBox2.Text == "")
            {
                errorProvider2.SetError(textBox1, "Veuillez entrer votre nom");
                errorProvider2.SetError(textBox2, "Veuillez entrer un mot de passe");
            }
            else
            {
                errorProvider2.Clear();
                errorProvider3.Clear();
            }
        }
    }
}
