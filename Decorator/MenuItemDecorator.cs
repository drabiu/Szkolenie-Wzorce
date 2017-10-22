using Jedzenie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class MenuItemDecorator : IMenuItem
    {
        protected IMenuItem _menuItem;
        public virtual decimal Price { get; }

        protected MenuItemDecorator(IMenuItem menuItem)
        {
            _menuItem = menuItem;
        }

        public int Number => _menuItem.Number;
        public string Name => _menuItem.Name;
    }
}
