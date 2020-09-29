using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feuille3
{
    interface IArticleDao
    {
        Article getArticleById(int id);
        List<Article> getArticles();
    }
}
