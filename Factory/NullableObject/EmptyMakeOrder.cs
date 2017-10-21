using System;
using System.Collections.Generic;

namespace Jedzenie
{
    public class EmptyMakeOrder : IMakeOrder
    {
        public IEnumerable<IMenuItem> ShowOrderDetails(IBasket basket)
        {
            return new List<IMenuItem>();
        }
    }
}