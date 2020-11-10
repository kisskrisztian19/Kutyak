using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutyak
{
    class Kutyafajta
    {
        private int id; private string nev, eredetiNev;

        public int ID { get { return id; } }
        public string Nev { get { return nev; } }
        public string EredetiNev { get { return eredetiNev; } }
        public Kutyafajta(int id, string nev, string eredetiNev)
        {
            this.id = id;
            this.nev = nev;
            this.eredetiNev = eredetiNev;
        }
    }
}
