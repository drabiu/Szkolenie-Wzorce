using System.Collections.Generic;

namespace Jedzenie
{
    public class Basket : IBasket
    {
        private readonly IList<IMenuItem> _items;

        public Basket()
        {
            _items = new List<IMenuItem>(16);  
        }

        public void Add(IMenuItem item)
        {
            _items.Add(item);
        }

        public IEnumerable<IMenuItem> GetItems()
        {
            return _items;
        }

        public void ClearItems()
        {
            _items.Clear();
        }
    }
}