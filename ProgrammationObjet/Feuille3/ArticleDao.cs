using System;
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
    }
}
