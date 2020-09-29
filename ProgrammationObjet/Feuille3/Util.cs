using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feuille3
{
    class Util
    {
        public static List<Article> getArticles()
        {
            List<Article> collectionArticle = new List<Article>();

            collectionArticle.Add(new Article(1, "Article 1", DateTime.Now));
            collectionArticle.Add(new Article(2, "Article 2", DateTime.Now));
            collectionArticle.Add(new Article(3, "Article 3", DateTime.Now));
            collectionArticle.Add(new Article(4, "Article 4", DateTime.Now));
            collectionArticle.Add(new Article(5, "Article 5", DateTime.Now));

            return collectionArticle;
        }
    }
}
