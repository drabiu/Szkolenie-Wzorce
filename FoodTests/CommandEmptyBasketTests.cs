using Jedzenie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using NSubstitute;

namespace FoodTests
{
    public class CommandEmptyBasketTests
    {
        [Fact]
        public void Command_should_execute_clear_on_basket()
        {
            var basket = Substitute.For<IBasket>();
            var command = new CommandEmptyBasket(basket);
            command.Execute();

            basket.Received(1).ClearItems();
        }
    }
}
