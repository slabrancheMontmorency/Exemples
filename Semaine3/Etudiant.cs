using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semaine3
{
    class Etudiant
    {
        private string nom;


        private string prenom;
        private int noEtudiant;

        public Etudiant()
        {
            this.nom = null;

            this.prenom = null;
            this.noEtudiant = 0;
        }

        public Etudiant(string nom, string prenom, int noEtudiant )
        {
            this.nom = nom;
            this.prenom = prenom;
            this.noEtudiant = noEtudiant;

        }

        public string toString()
        {
            return prenom + " " + nom + " numéro: " + noEtudiant;
        }

        public string Nom
        {
            get { return this.nom; }
            set { this.nom = value; }

        }

        public string Prenom
        {
            get { return this.prenom; }
            set { this.prenom = value; }

        }

        public int NoEtudiant
        {
            get { return this.noEtudiant; }
            set { this.noEtudiant = value; }

        }

    }
}
