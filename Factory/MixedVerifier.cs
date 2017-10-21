namespace Jedzenie
{
    public class MixedVerifier : IBasketVerifier
    {
        public bool Verify(IBasket basket)
        {
            var pizza = new PizzaVerifier();
            var kantyna = new KantynaBasketVerifier();

            return pizza.Verify(basket) && kantyna.Verify(basket);
        }
    }
}