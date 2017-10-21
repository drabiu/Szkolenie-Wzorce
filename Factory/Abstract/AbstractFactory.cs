using System.Collections;

namespace Jedzenie
{
    public abstract class AbstractFactory
    {
        public abstract IMenu GetMenu();

        public IBasket CreateBasket()
        {
            return new Basket();
        }

        public abstract IBasketVerifier GetVerifier();

        public abstract IMakeOrder CreateOrder();
    }
}