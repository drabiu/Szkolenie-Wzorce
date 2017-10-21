using System.Collections.Generic;

namespace Jedzenie
{
    public interface IMakeOrder
    {
        IEnumerable<IMenuItem> ShowOrderDetails(IBasket basket);
    }
}