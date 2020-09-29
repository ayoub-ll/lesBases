using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Feuille3
{
    class Program
    {
        IArticleDao articleDao = new ArticleDao();

        static void Main(string[] args)
        {
            Program prog = new Program();
            prog.AfficherArticles();
        }


        /* 3.1 - Nombres premiers */
        public List<int> getNombrePremiers()
        {
            List<int> nombres = new List<int> { 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            return (from nbPremier in nombres
                    where (Enumerable.Range(2, (int)Math.Sqrt(nbPremier))
                        .All(divisor => nbPremier % divisor != 0))
                    select nbPremier).ToList();
        }

        /* 3.2 - Années bisextiles */
        public void TrouverAnneesBisextiles()
        {
            //List<int> listeAnnees = new List<int> { 2000, 2001, 2002, 2003, 2004, 2005, 2006, 2007, 2008, 2009, 2010, 2011, 2012, 2013, 2014 };
            List<int> listeAnnees = new List<int> { 2014, 2015 };

            List<int> anneesBisextiles = new List<int>();
            var query = (from anneeBisextile in listeAnnees where ((anneeBisextile % 4 == 0 && anneeBisextile % 100 != 0) || (anneeBisextile % 400 == 0)) select anneeBisextile);

            if (query.ToList().Count() != 0)
            {
                foreach (int i in query.ToList())
                {
                    Console.WriteLine(i + " ");
                }
                Console.ReadLine();
            }
            else
            {
                int derniereAnneeDansLaListe = listeAnnees.Max();
                while (query.Count() == 0)
                {
                    listeAnnees.Add(listeAnnees.Last() + 1);
                }
                foreach (int i in query.ToList())
                {
                    Console.WriteLine(i + " ");
                }
                Console.ReadLine();
            }
        }

        /* 3.3 - Lambda */
        public void TrouverNombresDivisiblesPar5()
        {
            List<int> nombres_3 = new List<int> { 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            List<int> nombresDivisiblesPar5 = nombres_3.Where(n => (n % 5 == 0)).ToList();
        }

        /* 3.4 - DAO */
        public void AfficherArticles()
        {
            Console.WriteLine(articleDao.getArticleById(2));


            /* Toute la liste */
            foreach (Article article in articleDao.getArticles())
                Console.WriteLine(article);
            Console.ReadLine();
        }

        /* 3.5 - Requête à double valeur de retour */
        public void AfficherQuantiteEtPrix()
        {
            articleDao.getArticleInfo1("Article 5");
        }
    }
}
