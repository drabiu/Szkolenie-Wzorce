using System.Collections.Generic;

namespace Jedzenie
{
    public interface IBasket
    {
        void Add(IMenuItem item);
        IEnumerable<IMenuItem> GetItems();
        void ClearItems();
    }
}