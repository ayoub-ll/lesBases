﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feuille3
{
    class ArticleDao : IArticleDao
    {
        public List<Article> listeArticles;

        public ArticleDao()
        {
            this.listeArticles = Util.getArticles();
        }

        public Article getArticleById(int id)
        {
            return this.listeArticles.Where(a => a._id.Equals(id)).FirstOrDefault();
        }

        public List<Article> getArticles()
        {
            return this.listeArticles;
        }

        /* 3.5 - Requête à double valeur de retour */
        public (int, int) getArticleQuantiteAndPrix(string nom)
        {
            var ret =  this.listeArticles.Where(a => a._nom.Equals(nom)).Select(a => new { a._quantite, a._prix })
                .FirstOrDefault();

            return (ret._quantite, ret._prix);
        }

        /* 3.6 - Requête à double valeur de retour avec TUPLE */
        public Tuple<int, int> getArticleQuantiteAndPrixTuple(string nom)
        {
            return this.listeArticles.Where(a => a._nom.Equals(nom)).Select(a => new Tuple<int, int>(a._quantite, a._prix))
                .FirstOrDefault();
        }

        /* 3.7 - Agregations */
        public string getArticleQuantiteMinMaxAndAverage()
        {
            StringBuilder res = new StringBuilder();
            res.AppendLine("Articles quantite MIN: " + this.listeArticles.Min(a => a._quantite));
            res.AppendLine("Articles quantite MAX: " + this.listeArticles.Max(a => a._quantite));
            res.AppendLine("Prix moyen: " + this.listeArticles.Average(a => a._prix));

            return res.ToString();
        }
    }
}
