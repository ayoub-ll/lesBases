using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListeChainée
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
        public Object this[int i] { get {
                Element elementCourant = this._Début;
                int position = 0;

                if(i > this.NbEléments)
                {
                    Console.WriteLine("Index demandé dépasse les limites de ce tableau");
                }
                
                while (elementCourant.Suivant != null)
                {
                    if (position == i)
                    {
                        return elementCourant.Objet;
                    }

                    elementCourant = elementCourant.Suivant;
                    position++;
                }

                return elementCourant.Objet;
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

        public void InsérerFin(Object objet)
        {
            Element nouveauElement = new Element(objet);
            Element dernierElement = this._Début;

            if(dernierElement == null)
            {
                this._Début = nouveauElement;
                _NbEléments++;
                return;
            }

            //Recherche du dernier element
            while(dernierElement.Suivant != null)
            {
                dernierElement = dernierElement.Suivant;
            }
            dernierElement.Suivant = nouveauElement;

            _NbEléments++;
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
            while (elementCourant.Suivant != null)
            {
                elementCourant = elementCourant.Suivant;
                Console.WriteLine(elementCourant.ToString());
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
