﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jedzenie
{
    public class NullableFactory : AbstractFactory
    {
        public override IMenu GetMenu()
        {
            return new EmptyMenu();
        }

        private class EmptyMenu : IMenu
        {
            public List<IMenuItem> Items()
            {
                return new List<IMenuItem>();
            }
        }
    }   
}
