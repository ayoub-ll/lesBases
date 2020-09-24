using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Société
{
    class Chef : Employé
    {
        protected string _Service { get; set; }

        public Chef(string nom, string prenom, int age, decimal salaire, string service) : base(nom, prenom, age, salaire)
        {
            this._Service = service;
        }

        public void setService(string service)
        {
            this._Service = service;
        }

        public override string ToString() => ("Je suis: " + this._Prénom + " " + this._Nom + " et j'ai " + this._Age + " et je touche " + this._Salaire + "€ et je suis du service " + this._Service);

        public void Afficher()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
