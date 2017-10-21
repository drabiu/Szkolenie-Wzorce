using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jedzenie
{
    public class NoVegeFactory : AbstractFactory
    {
        public override IMenu GetMenu()
        {
            throw new NotImplementedException();
        }

        public override IBasketVerifier GetVerifier()
        {
            throw new NotImplementedException();
        }

        public override IMakeOrder CreateOrder()
        {
            throw new NotImplementedException();
        }
    }
}
