using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ListeChainee
{
    class Element
    {
        Object _Objet;
        Element _Suivant;
        public Object Objet { get { return _Objet; } set { _Objet = value; } }
        public Element Suivant { get { return _Suivant; } set { _Suivant = value; } }

        public Element(Object objet)
        {
            this._Objet = objet;
        }
    }

    class Liste
    {
        private Element _Début;
        private int _NbEléments;
        public int NbEléments { get { return _NbEléments; } }
        public Element this[int i] { get {
                Element elementCourant = this._Début;

                if (elementCourant == null)
                {
                    Console.WriteLine("Tableau vide");
                    Console.ReadLine();
                    return null;
                }

                int position = 0;

                if(i > this.NbEléments)
                {
                    Console.WriteLine("Index demandé dépasse les limites de ce tableau");
                    Console.ReadLine();
                    return null;
                }

                
                while (elementCourant.Suivant != null)
                {
                    if (position == i)
                    {
                        return elementCourant;
                    }

                    elementCourant = elementCourant.Suivant;
                    position++;
                }

                return elementCourant;
            } }

        public Liste()
        {
            _Début = null;
            _NbEléments = 0;
        }

        public void InsérerDébut(Object objet)
        {
            Element nouveauElement = new Element(objet);
            nouveauElement.Suivant = this._Début;
            this._Début = nouveauElement;
            _NbEléments++;
        }

        // (1, (2,3))
        public void InsérerFin(Object objet)
        {
            if (this._Début == null)
            {
                this.InsérerDébut(new Element(objet));
            } else
            {
                this.InsérerFin(_Début.Suivant);
            }
        }

        public void Lister()
        {
            if(this._Début == null)
            {
                Console.WriteLine("Liste vide");
                Console.ReadLine();
                return;
            }

            Element elementCourant = this._Début;

            Console.WriteLine(elementCourant.Objet.ToString());
            while (elementCourant.Suivant != null)
            {
                elementCourant = elementCourant.Suivant;
                Console.WriteLine(elementCourant.Objet.ToString());
            }
            Console.ReadLine();
        }

        public void Vider()
        {
            Element elementCourant = this._Début;
            Element elementSuivant = this._Début.Suivant;

            while (elementSuivant != null)
            {
                elementSuivant = elementSuivant.Suivant;
                elementCourant = null;
            }

            this._Début = null;
            this._NbEléments = 0;
        }
    }
}
