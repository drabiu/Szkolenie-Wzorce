using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jedzenie
{
    public class LudoviskoFactory : AbstractFactory
    {
        public override IMenu GetMenu()
        {
            return new LudoviskoMenu();
        }

        public override IBasketVerifier GetVerifier()
        {
            return new LudoviskoBasketVerifier();
        }
    }

    public class LudoviskoBasketVerifier : IBasketVerifier
    {
        public bool Verify(IBasket basket)
        {
            return true;
        }
    }

    public class LudoviskoMenu : IMenu
    {
        public List<IMenuItem> Items()
        {
            return new List<IMenuItem>()
            {
                new LudoviskoMenuItem(1, "kalosze"),
                new LudoviskoMenuItem(2, "bambosze"),
                new LudoviskoMenuItem(3, "Lunch")
            };
        }
    }

    public class LudoviskoMenuItem : IMenuItem
    {
        public LudoviskoMenuItem(int number, string name)
        {
            Name = name;
            Number = number;
        }

        public string Name { get; }

        public int Number { get; }
    }
}
