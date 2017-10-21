using System;
using System.Collections.Generic;
using Factory.ludovisko;

namespace Jedzenie
{
    public class MakeOrderAdapter : IMakeOrder
    {
        public IEnumerable<IMenuItem> ShowOrderDetails(IBasket basket)
        {
            var api = new LudoviskoAPIClient("a", "b");
            var order = Convert(basket);
            api.SendOrder(order);

            return basket.GetItems();
        }

        private IList<Tuple<string, int>> Convert(IBasket basket)
        {
            throw new NotImplementedException();
        }
    }
}