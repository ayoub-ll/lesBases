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

            collectionArticle.Add(new Article(1, "Article 1", DateTime.Now, 2, 15));
            collectionArticle.Add(new Article(2, "Article 2", DateTime.Now, 5, 22));
            collectionArticle.Add(new Article(3, "Article 3", DateTime.Now, 1, 97));
            collectionArticle.Add(new Article(4, "Article 4", DateTime.Now, 9, 55));
            collectionArticle.Add(new Article(5, "Article 5", DateTime.Now, 10, 5));

            return collectionArticle;
        }
    }
}
