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
        public string _titre;
        public DateTime _dateParution;

        public Article(int id, string titre, DateTime dateParution)
        {
            this._id = id;
            this._titre = titre;
            this._dateParution = dateParution;
        }

        public override string ToString()
        {
            return "Article n°" + this._id + "\ntitre:" + this._titre + "\ndate de parution:" + this._dateParution;
        }
    }
}
