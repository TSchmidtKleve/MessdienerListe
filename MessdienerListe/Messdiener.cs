using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessdienerListe
{

    class Messdiener
    {
        public int id;
        public string vorname, nachname, bemerkung;
        public bool mo,di,mi,don,fr,sa,so;
        

        public Messdiener(int Id, string Vorname, string Nachname,bool Mo,bool Di,bool Mi,bool Don, bool Fr,bool Sa,bool So,string Bemerkung)
        {
            int id = Id;
            string vorname = Vorname;
            string nachname = Nachname;
            bool mo = Mo;
            bool di = Di;
            bool mi = Mi;
            bool don = Don;
            bool fr = Fr;
            bool sa = Sa;
            bool so = So;
            string bemerkung = Bemerkung;
        }

        public Messdiener()
        {

        }

        public int Id
        {
            get { return this.id; }
        }

        public string Vorname
        {
            get { return vorname; }
        }

        public string Nachname
        {
            get { return nachname; }
        }

        public bool Mo
        {
            get { return mo; }
        }

        public bool Di
        {
            get { return di; }
        }

        public bool Mi
        {
            get { return mi; }
        }

        public bool Don
        {
            get { return don; }
        }

        public bool Fr
        {
            get { return fr; }
        }

        public bool Sa
        {
            get { return sa; }
        }

        public bool So
        {
            get { return so; }
        }

        public string Bemerkung
        {
            get { return bemerkung; }
        }

    }
}
