using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Société
{
    class Personne
    {
        protected string _Nom { get; set; }
        protected string _Prénom { get; set; }
        protected int _Age { get; set; }

        public Personne(string nom, string prenom)
        {
            this._Nom = nom;
            this._Prénom = prenom;
            this._Age = 0;
        }

        public Personne(string nom, string prenom, int age)
        {
            this._Nom = nom;
            this._Prénom = prenom;
            this._Age = age;
        }

        public override string ToString() => ("Je suis: " + this._Prénom + " " + this._Nom + " et j'ai " + this._Age);

        public void Afficher()
        {
            Console.WriteLine(this.ToString());
        }

        public void Afficher(string nom)
        {
            Console.WriteLine(nom);
        }

        public static Personne operator ++(Personne personne)
        {
            personne._Age++;
            return personne;
        }
    }
}
