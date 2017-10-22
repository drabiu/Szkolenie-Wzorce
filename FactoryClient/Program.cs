using System;
using System.Collections.Generic;
using Decorator;
using Factory;

namespace Jedzenie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gdzie jemy?");
            var place = Console.ReadLine();
            var f = new FlighweightFactory();
            var factory = f.CreateFactory(place);

            var menu = factory.GetMenu();
            ShowMenu(menu.Items());

            var basket = factory.CreateBasket();

            //tu jest command
            var executor = new CommandExecutor();
            executor.Execute(new CommandAddMenuItem(basket, menu.Items()[0]));
            executor.Execute(new CommandAddMenuItem(basket, menu.Items()[2]));
            executor.Execute(new CommandEmptyBasket(basket));
            executor.Execute(new CommandAddMenuItem(basket, menu.Items()[0]));
            executor.Execute(new CommandAddMenuItem(basket, menu.Items()[2]));

            var decoratorGruby = new MenuItemNaGrubymDecorator(menu.Items()[3], 18);
            decoratorGruby = new MenuItemNaGrubymDecorator(decoratorGruby, decoratorGruby.Price);
            var decoratorCienki = new MenuItemNaCienkimDecorator(menu.Items()[4], 18);

            executor.Execute(new CommandAddMenuItem(basket, decoratorGruby));
            executor.Execute(new CommandAddMenuItem(basket, decoratorCienki));

            //tu jest factory
            //            basket.Add(menu.Items()[0]);
            //            basket.Add(menu.Items()[2]);

            var verify = factory.GetVerifier();
            if (verify.Verify(basket))
            {
                Console.WriteLine("można zamówić");
            }

            var order = factory.CreateOrder();
            ShowOrder(order.ShowOrderDetails(basket));

            Console.WriteLine("Historia komend:");
            ShowHistory(executor.GetCommandHistory());

            Console.ReadKey();
        }

        private static void ShowMenu(IEnumerable<IMenuItem> items)
        {
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }

        private static void ShowOrder(IEnumerable<IMenuItem> items)
        {
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }

        private static void ShowHistory(IEnumerable<string> items)
        {
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
