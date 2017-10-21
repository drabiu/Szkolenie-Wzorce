using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            var order = factory.CreateBasket();

            order.Add(menu.Items()[0]);
            order.Add(menu.Items()[2]);

            var verify = factory.GetVerifier();
            if (verify.Verify(order))
            {
                Console.WriteLine("można zamówić");
            }

            Console.ReadKey();
        }

        private static void ShowMenu(IEnumerable<IMenuItem> items)
        {
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
