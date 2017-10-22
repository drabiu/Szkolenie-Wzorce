using System;

namespace Jedzenie
{
    public class CommandEmptyBasket : ICommand
    {
        private readonly IBasket _basket;

        public CommandEmptyBasket(IBasket basket)
        {
            _basket = basket;
        }

        public void Execute()
        {
            _basket.ClearItems();
        }
    }
}