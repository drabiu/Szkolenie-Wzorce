using Jedzenie;

namespace Decorator
{ 
    public class MenuItemNaGrubymDecorator : MenuItemDecorator
    {
        public override decimal Price { get; }

        public MenuItemNaGrubymDecorator(IMenuItem menuItem, decimal price) : base(menuItem)
        {
            Price = price + 2;
        }

        public override string ToString()
        {
            return $"{Number}) {Name} : {Price}zł";
        }
    }
}