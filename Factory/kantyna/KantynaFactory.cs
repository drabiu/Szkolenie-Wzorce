﻿using System;
using System.Collections.Generic;

namespace Jedzenie
{
    public class KantynaFactory : AbstractFactory
    {
        public override IMenu GetMenu()
        {
            return new KantynaExampleMenu();
        }

        public override IBasketVerifier GetVerifier()
        {
            return new MixedVerifier();
        }

        public override IMakeOrder CreateOrder()
        {
            return new MakeOrder();
        }

        private class KantynaExampleMenu : IMenu
        {
            public List<IMenuItem> Items()
            {
                return new List<IMenuItem>()
                {
                    new MenuItem(1, "Salami"),
                    new MenuItem(2, "Kurczak"),
                    new MenuItem(3, "Pieczarki"),
                    new MenuItem(4, "na grubym"),
                    new MenuItem(5, "na cienkim")
                };
            }           
        }     
    }
}