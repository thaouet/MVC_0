using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_0
{
    class EtudiantControleur
    {
        private Etudiant model;
        private EtudiantView view;

        public EtudiantControleur(Etudiant model, EtudiantView view)
        {
            this.model = model;
            this.view = view;
        }

        public void setNomEtudiant(String nom)
        {
            model.Nom = nom;
        }

        public String getNomEtudiant()
        {
            return model.Nom;
        }

        public void setNceEtudiant(String nce)
        {
            model.Nce = nce; 
        }

        public String getNceEtudiant()
        {
            return model.Nce;
        }

        public void updateView()
        {
            view.AfficherDetailsEtudinat(model.Nom, model.Nce);
        }



    }
}
