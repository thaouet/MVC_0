using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_0
{
    //Modele
    class Etudiant
    {
        private string nce;
        private string nom;

        //public Etudiant(string nce, string nom)
        //{
        //    this.nce = nce;
        //    this.nom = nom;
        //}


        public string Nce
        {
            get
            {
                return nce;
            }

            set
            {
                nce = value;
            }
        }

        public string Nom
        {
            get
            {
                return nom;
            }

            set
            {
                nom = value;
            }
        }
    }
}
