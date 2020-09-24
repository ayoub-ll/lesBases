using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListeChainee
{
    class ListeEnumeration : IEnumerator
    {
        Liste _Liste;
        int _indiceCourant;
        public Object Current { get { return this._Liste[_indiceCourant]; }}

        public ListeEnumeration(Liste liste)
        {
            this._Liste = liste;
        }

        bool IEnumerator.MoveNext()
        {
            if (this._Liste[_indiceCourant + 1] != null)
            {
                this._indiceCourant++;
                return true;
            }
            return false;
        }

        void IEnumerator.Reset()
        {
            this._indiceCourant = 0;
        }

        public IEnumerator GetEnumerator()
        {
            return (IEnumerator)this;
        }
    }
}
