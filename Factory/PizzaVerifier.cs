namespace Jedzenie
{
    public class PizzaVerifier : IBasketVerifier
    {
        public bool Verify(IBasket basket)
        {
            return true;
        }
    }
}