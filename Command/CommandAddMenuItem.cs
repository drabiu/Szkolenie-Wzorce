using System;

namespace Jedzenie
{
    public class CommandAddMenuItem : ICommand
    {
        private readonly IMenuItem _menuItem;
        private readonly IBasket _basket;

        public CommandAddMenuItem(IBasket basket, IMenuItem menuItem)
        {
            _menuItem = menuItem;
            _basket = basket;
        }

        public void Execute()
        {
           _basket.Add(_menuItem);
        }
    }
}