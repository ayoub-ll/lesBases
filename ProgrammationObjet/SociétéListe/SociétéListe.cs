using ListeChainée;
using Société;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SociétéListe
{
    class GérerSociétéListe
    {
        static void Main(String[] args)
        {
            ListeChainée.Liste liste = new ListeChainée.Liste();

            /*
            liste.InsérerDébut(new Employé("nom1", "prenom1", 1, 1500));
            liste.InsérerDébut(new Employé("nom2", "prenom2", 2, 1500));
            liste.InsérerDébut(new Employé("nom3", "prenom3", 3, 1500));
            liste.InsérerDébut(new Employé("nom4", "prenom4", 4, 1500));
            liste.InsérerDébut(new Employé("nom5", "prenom5", 5, 1500));
            liste.InsérerDébut(new Chef("nom6", "prenom4", 4, 1500, "manutention"));
            liste.InsérerDébut(new Chef("nom7", "prenom5", 5, 1500, "cartons"));
            liste.InsérerDébut(new Directeur("nom8", "prenom4", 4, 1500, "cartons", "IT SOCIETY"));
            */

            /* Pour vérifier l'indexeur
            Console.WriteLine(liste[2]);
            Console.ReadLine();
            */

            /*
            liste.Lister();

            liste.Vider();
            liste.Lister();
            */

            liste.InsérerFin(new Employé("nom1", "prenom1", 1, 1500));
            liste.InsérerFin(new Employé("nom2", "prenom2", 2, 1500));
            liste.InsérerFin(new Employé("nom3", "prenom3", 3, 1500));

            liste.InsérerFin(new Employé("nom3", "prenom3", 3, 1500));
            liste.InsérerFin(new Employé("nom4", "prenom4", 4, 1500));
            /*liste.InsérerFin(new Employé("nom5", "prenom5", 5, 1500));
            liste.InsérerFin(new Chef("nom6", "prenom4", 4, 1500, "manutention"));
            liste.InsérerFin(new Chef("nom7", "prenom5", 5, 1500, "cartons"));
            liste.InsérerFin(new Directeur("nom8", "prenom4", 4, 1500, "cartons", "IT SOCIETY"));
            */

            liste.Lister();
        }
    }
}
