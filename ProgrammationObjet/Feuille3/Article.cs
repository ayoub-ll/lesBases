using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feuille3
{
    class Article
    {
        public int _id;
        public string _nom;
        public DateTime _dateParution;
        public int _quantite;
        public int _prix;

        public Article(int id, string nom, DateTime dateParution, int quantite, int prix)
        {
            this._id = id;
            this._nom = nom;
            this._dateParution = dateParution;
            this._prix = prix;
            this._quantite = quantite;
        }

        public override string ToString()
        {
            return "Article n°" + this._id + "\nnom:" + this._nom + "\ndate de parution:" + this._dateParution
                + "\nquantite:" + this._quantite + "\nprix:" + this._quantite;
        }
    }
}
