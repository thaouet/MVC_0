using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_0
{
    class EtudiantView
    {
        public void AfficherDetailsEtudinat(String nom, String nce)
        {
           Console.WriteLine("Etudiant: ");
            Console.WriteLine("Nom: " + nom);
            Console.WriteLine("N.C.E: " + nce);
        }
    }
}
