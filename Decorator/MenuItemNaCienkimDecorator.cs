using Jedzenie;

namespace Decorator
{
    public class MenuItemNaCienkimDecorator : MenuItemDecorator
    {
        public override decimal Price { get; }

        public MenuItemNaCienkimDecorator(IMenuItem menuItem, decimal price) : base(menuItem)
        {
            Price = price;
        }

        public override string ToString()
        {
            return $"{Number}) {Name} : {Price}zł";
        }
    }
}