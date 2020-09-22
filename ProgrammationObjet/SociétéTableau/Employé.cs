using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SociétéTableau
{
    class Employé : Personne
    {
        protected decimal _Salaire { get; set; }

        public Employé(string nom, string prenom, int age, decimal salaire) : base(nom, prenom, age)
        {
            this._Salaire = salaire;
        }

        public decimal getSalaire()
        {
            return this._Salaire;
        }

        public void setSalaire(decimal salaire)
        {
            this._Salaire = salaire;
        }
        public override string ToString() => ("Je suis: " + this._Prénom + " " + this._Nom + " et j'ai " + this._Age + " et je touche " + this._Salaire + "€");

        public void Afficher()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
