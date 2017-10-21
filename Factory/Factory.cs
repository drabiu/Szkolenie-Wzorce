using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class Factory
    {
    }

    public class Klient
    {
        public void DodajZamowienie(Zamowienie zamowienie)
        {

        }
    }

    public class Zamowienie
    {
        public Klient Klient { get; set; }
    }
}
