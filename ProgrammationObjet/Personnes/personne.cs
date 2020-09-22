using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personnes
{
    class personne
    {
        public static int nbPersonnes = 0;

        private string nom;
        private string prenom;
        private int age;

        public personne(string nom, string prenom, int age)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.age = age;
            nbPersonnes++;
        }

        public void AfficherPersonne()
        {
            Console.WriteLine("Je suis: " + prenom + " " + nom + " et j'ai " + age);
        }

        public static int Combien()
        {
            return nbPersonnes;
        }
    }
}
