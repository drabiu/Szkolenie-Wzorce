using System;
using System.Collections.Generic;

namespace Jedzenie
{
    public class KantynaFactory : AbstractFactory
    {
        public override IMenu GetMenu()
        {
            return new KantynaExampleMenu();
        }

        private class KantynaExampleMenu : IMenu
        {
            public List<IMenuItem> Items()
            {
                return new List<IMenuItem>()
                {
                    new MenuItem(1, "Salami"),
                    new MenuItem(2, "Kurczak"),
                    new MenuItem(3, "Pieczarki")
                };
            }

            private class MenuItem : IMenuItem
            {
                public MenuItem(int number, string name)
                {
                    Name = name;
                    Number = number;
                }

                public string Name { get; }

                public int Number { get; }

                public override string ToString()
                {
                    return $"{Number}) {Name}";
                }
            }
        }
    }
   
}