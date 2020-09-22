using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticleTypé
{
    public enum typeArticle { alimentaire, droguerie, habillement, loisir };
    public class ArticleTypé
    {
        protected string designation { get; set; }
        protected int prix { get; set; }
        protected typeArticle type { get; set; }

        public ArticleTypé(string designation, int prix, typeArticle type)
        {
            this.designation = designation;
            this.prix = prix;
            this.type = type;
        }
        public void Acheter()
        {
        }
        public void AfficherArticle()
        {
            Console.Write("designation: {0} \nprix: {1} \ntype: {2}", this.designation, this.prix, this.type);
        }

        static void Main(string[] args)
        {
            // TEST 1 (sans saisie)
            /*
            Livre livre1 = new Livre("livre1", 10, "isbn1", 15, typeArticle.loisir);
            Disque disque1 = new Disque("disque1", 12, "isbn1", typeArticle.loisir);
            Video video1 = new Video("video1", 14, 10, typeArticle.loisir);

            livre1.AfficherLivre();
            Console.ReadLine();
            */
            // FIN TEST 1 

            // TEST AVEC SAISIE
            Console.WriteLine("Quel type d'article voulez vous ? (alimentaire, droguerie, habillement ou loisir)");
            string typeArticleChoisi = Console.ReadLine();
            Console.WriteLine("Vous avez choisi: {0}", typeArticleChoisi);
            ArticleTypé article = null;

            switch (typeArticleChoisi)
            {
                case "alimentaire":
                    article = new ArticleTypé("article alimentaire", 20, typeArticle.alimentaire);
                    break;
                case "droguerie":
                    article = new ArticleTypé("article alimentaire", 20, typeArticle.alimentaire);
                    break;
                case "habillement":
                    article = new ArticleTypé("article alimentaire", 20, typeArticle.habillement);
                    break;
                case "loisir":
                    article = new ArticleTypé("article alimentaire", 20, typeArticle.loisir);
                    break;
            }

            Console.WriteLine("Les informations de l'article que vous avez crée:\n");
            article.AfficherArticle();
            Console.ReadLine();
            // FIN TEST AVEC SAISIE
        }
    }

    class Livre : ArticleTypé
    {
        protected string isbn;
        protected int nbPages;

        public Livre(string designation, int prix, string isbn, int nbPages, typeArticle type) : base(designation, prix, type)
        {
            this.isbn = isbn;
            this.nbPages = nbPages;
        }

        public void AfficherLivre()
        {
            this.AfficherArticle();
            Console.Write("isbn: {0} \nnbPages: {1}", this.isbn, this.nbPages);
        }
    }

    class Disque : ArticleTypé
    {
        protected string label;

        public Disque(string designation, int prix, string label, typeArticle type) : base(designation, prix, type)
        {
            this.label = label;
        }

        public void AfficherDisque()
        {
            this.AfficherArticle();
            Console.Write("label: {0}", this.label);
        }
    }

    class Video : ArticleTypé
    {
        protected int duree;

        public Video(string designation, int prix, int duree, typeArticle type) : base(designation, prix, type)
        {
            this.duree = duree;
        }

        public void AfficherVideo()
        {
            this.AfficherArticle();
            Console.Write("duree: {0}", this.duree);
        }
    }

    class Poche : Livre
    {
        private string categorie;

        public Poche(string designation, int prix, string isbn, int nbPages, string categorie, typeArticle type) : base(designation, prix, isbn, nbPages, type)
        {
            this.categorie = categorie;
        }
    }

    class Broche : Livre
    {
        public Broche(string designation, int prix, string isbn, int nbPages, string categorie, typeArticle type) : base(designation, prix, isbn, nbPages, type)
        {
        }
    }
}
