using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semaine3_Live
{
    class Etudiant
    {
       
        private string prenom;
        private string nom;
        private int noEtudiant;

        public Etudiant()
        {
            prenom = "";
            nom = "";
            noEtudiant = 0;
        }

        public Etudiant(string prenom, string nom, int noEtudiant)
        {
            this.prenom = prenom;
            this.nom = nom;
            this.noEtudiant = noEtudiant;
        }

        
        public override string ToString()
        {
            string chaine = "";
            chaine += "Prénom: " + prenom;
            chaine += "\nNom: " + nom;
            chaine += "\nNuméro d'étudiant: " + noEtudiant;
            return chaine;
        }


        public string Prenom
        {
            get { return this.prenom; }
            set { this.prenom = value; }
        }



    }
}
