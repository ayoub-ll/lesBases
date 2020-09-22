using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SociétéTableau
{
    class Directeur : Chef
    {
        protected string _Société { get; set; }

        public Directeur(string nom, string prenom, int age, decimal salaire, string service, string societe) : base(nom, prenom, age, salaire, service)
        {
            this._Société = societe;
        }

        public override string ToString() => ("Je suis: " + this._Prénom + " " + this._Nom + " et j'ai " + this._Age + " et je touche " + this._Salaire + "€ et je suis du service " + this._Service + ", je suis le boss de la societe " + this._Société);

        public void Afficher()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
