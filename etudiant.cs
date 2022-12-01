using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1
{
    internal class etudiant
    {
        private String Nom;
        private String Prenom;
        private String CNE;
        //constructeur vide
        public etudiant() { }
        //constructeur paramétré
        public etudiant(String CNE, String Nom, String Prenom)
        {
            this.CNE = CNE;
            this.Nom = Nom;
            this.Prenom = Prenom;
        }

        //getter et setter de CNE
        public String getCne()
        {
            return CNE;
        }

        public void setCne(String cne)
        {
            this.CNE = cne;
        }


        //getter et setter d Prenom
        public String getPrenom()
        {
            return Prenom;
        }
        public void setPrenom(String prenom)
        {
            this.Prenom = prenom;
        }


        //getter et setter de Nom
        public String getNom()
        {
            return Nom;
        }

        public void setNom(String nom)
        {
            this.Nom = nom;
        }
    }
}
