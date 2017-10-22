using System.Collections.Generic;

namespace Jedzenie
{
    public class LudoviskoMenu : IMenu
    {
        public List<IMenuItem> Items()
        {
            return new List<IMenuItem>()
            {
                new LudoviskoMenuItem(1, "kalosze"),
                new LudoviskoMenuItem(2, "bambosze"),
                new LudoviskoMenuItem(3, "Lunch"),
                new LudoviskoMenuItem(4, "na grubym"),
                new LudoviskoMenuItem(5, "na cienkim")
            };
        }
    }
}