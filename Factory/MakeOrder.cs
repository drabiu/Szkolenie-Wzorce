using System.Collections.Generic;

namespace Jedzenie
{
    public class MakeOrder : IMakeOrder
    {
        public IEnumerable<IMenuItem> ShowOrderDetails(IBasket basket)
        {
            return basket.GetItems();
        }
    }
}