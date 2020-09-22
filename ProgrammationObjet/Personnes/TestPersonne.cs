using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personnes
{
    class TestPersonne
    {
        static void Main(String[] args)
        {
            personne personne1 = new personne("DURANT", "MARC", 30);
            personne personne2 = new personne("PINOT", "THIBAUT", 45);
            personne personne3 = new personne("CHABAL", "SEB", 40);

            Console.WriteLine(personne.nbPersonnes); //CHECK que le cpmpteur static de personnes et bien à 3
            Console.ReadLine();

        }
    }
}
