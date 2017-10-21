using System;
using System.Linq;

namespace Jedzenie
{
    public class KantynaBasketVerifier : IBasketVerifier
    {
        public bool Verify(IBasket basket)
        {
            return basket.GetItems().Any();
        }
    }
}