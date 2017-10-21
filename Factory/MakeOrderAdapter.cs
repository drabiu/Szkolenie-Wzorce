using System;
using System.Collections.Generic;

namespace Jedzenie
{
    public class MakeOrderAdapter : IMakeOrder
    {
        public IEnumerable<IMenuItem> ShowOrderDetails(IBasket basket)
        {
            throw new NotImplementedException();
        }
    }
}