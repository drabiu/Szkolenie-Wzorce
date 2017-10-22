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

    public class CommandAddMenuItemTests
    {
        [Fact]
        public void Command_should_add_menu_item_to_basket()
        {
            var basket = Substitute.For<IBasket>();
            var menuItem = Substitute.For<IMenuItem>();

            var command = new CommandAddMenuItem(basket, menuItem);

            command.Execute();

            basket.Received(1).Add(menuItem);
        }

        [Fact]
        public void Command_should_add_menu_item_to_basket_v2()
        {
            var basket = Substitute.For<IBasket>();
            var menuItem = Substitute.For<IMenuItem>();

            menuItem.Name.Returns("test pizza");
            menuItem.Number.Returns(500);

            var command = new CommandAddMenuItem(basket, menuItem);

            command.Execute();

            basket.Received(1).Add(Arg.Is<IMenuItem>(a => a.Name == "test pizza" && a.Number == 500));
        }
    }
}
