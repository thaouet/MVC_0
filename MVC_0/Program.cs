using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_0
{
    class Program
    {


        private static Etudiant GetEtudiant()
        {
            Etudiant e = new Etudiant();
            e.Nom ="Lina";
            e.Nce="E00010";
            return e;
        }


        static void Main(string[] args)
        {
            Etudiant model = GetEtudiant();

            EtudiantView view = new EtudiantView();

            EtudiantControleur controller = new EtudiantControleur(model, view);

            controller.updateView();

            //update model data
            controller.setNomEtudiant("Loujain");

            controller.updateView();

            Console.ReadLine();
        }

       





    }
    
}
