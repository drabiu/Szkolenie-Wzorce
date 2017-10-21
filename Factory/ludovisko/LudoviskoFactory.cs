using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jedzenie
{
    public class LudoviskoFactory : AbstractFactory
    {
        public override IMenu GetMenu()
        {
            return new LudoviskoMenu();
        }

        public override IBasketVerifier GetVerifier()
        {
            return new LudoviskoBasketVerifier();
        }

        public override IMakeOrder CreateOrder()
        {
            return new MakeOrder();
        }
    }
}
