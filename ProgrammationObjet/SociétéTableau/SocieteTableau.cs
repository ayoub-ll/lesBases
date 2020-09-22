using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SociétéTableau
{
    class SocieteTableau
    {
        static void Main(String[] args)
        {
            Personne[] tableauPersonnes = new Personne[8];

            tableauPersonnes[0] = new Employé("marc", "durant", 20, 1400);
            tableauPersonnes[1] = new Employé("laurant", "dupont", 21, 1500);
            tableauPersonnes[2] = new Employé("jean", "dujardin", 22, 1600);
            tableauPersonnes[3] = new Employé("antoine", "martial", 23, 1700);
            tableauPersonnes[4] = new Employé("pierre", "gasly", 24, 1800);
            tableauPersonnes[5] = new Chef("dubois", "jean", 25, 1900, "manutention");
            tableauPersonnes[6] = new Chef("dubois", "laurent", 26, 2000, "manutention");
            tableauPersonnes[7] = new Directeur("boss", "the", 26, 5000, "manutention", "PrestaIT");

            ++(tableauPersonnes[0]);
            ((Employé)tableauPersonnes[1]).setSalaire(9800);
            ((Chef)tableauPersonnes[5]).setService("cartons");

            foreach (Personne personne in tableauPersonnes)
            {
                personne.Afficher();
            }
            Console.ReadLine();
        }
    }
}
