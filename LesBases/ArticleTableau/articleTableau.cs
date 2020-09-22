using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArticleTypé;

namespace ArticleTableau
{
    enum typeArticle { alimentaire, droguerie, habillement, loisir };
    class ArticleTableau
    {

        static void Main(string[] args)
        {
            // EX tableaux
            ArticleTypé.ArticleTypé[] tableauArticles = new ArticleTypé.ArticleTypé[3];

            tableauArticles[0] = new ArticleTypé.ArticleTypé("article alimentaire", 20, ArticleTypé.typeArticle.alimentaire);
            tableauArticles[1] = new ArticleTypé.ArticleTypé("article loisir", 20, ArticleTypé.typeArticle.loisir);
            tableauArticles[2] = new ArticleTypé.ArticleTypé("article droguerie", 20, ArticleTypé.typeArticle.droguerie);

            foreach(ArticleTypé.ArticleTypé article in tableauArticles)
            {
                article.AfficherArticle();
            }
            Console.ReadLine();
        }
    }

}
