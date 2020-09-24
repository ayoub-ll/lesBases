using ListeChainee;
using Société;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocieteEnumeration
{
    class GererSocieteEnumeration
    {
        static void Main(String[] args)
        {
            ListeChainee.Liste liste = new ListeChainee.Liste();

            liste.InsérerDébut(new Employé("nom1", "prenom1", 1, 1500));
            liste.InsérerDébut(new Employé("nom2", "prenom2", 2, 1500));
            liste.InsérerDébut(new Employé("nom3", "prenom3", 3, 1500));
            liste.InsérerDébut(new Employé("nom4", "prenom3", 3, 1500));
            liste.InsérerDébut(new Employé("nom5", "prenom4", 4, 1500));
            liste.InsérerDébut(new Chef("nom6", "prenom4", 4, 1500, "manutention"));
            liste.InsérerDébut(new Chef("nom7", "prenom5", 5, 1500, "cartons"));
            liste.InsérerDébut(new Directeur("nom8", "prenom4", 4, 1500, "cartons", "IT SOCIETY"));

            ListeEnumeration listeEnum = new ListeEnumeration(liste);

            // AFFICHAGE AVEC L'INDEXEUR
            for(int i = 0; i < 8; i++)
                Console.WriteLine(liste[i].Objet.ToString());
            Console.ReadLine();

            // AFFICHAGE AVEC ENUM
            foreach(Element Element in listeEnum)
            {
                Console.WriteLine(Element.Objet.ToString());
            }

            Console.ReadLine();

        }
    }
}
