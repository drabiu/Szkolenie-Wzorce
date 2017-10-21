namespace Jedzenie
{
    public class EmptyVerifier : IBasketVerifier
    {
        public bool Verify(IBasket basket)
        {
            return false;
        }
    }
}