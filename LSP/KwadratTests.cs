using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Xunit;

namespace LSP
{
    public class KwadratTests
    {
        [Fact]
        public void Kwadrat_test()
        {
            var kwadrat = new Kwadrat(5);
            kwadrat.Pole.Should().Be(25);
            kwadrat.Obwod.Should().Be(20);
        }

        [Fact]
        public void Prostokat_test()
        {
            var prostokat = new Prostokat(5, 4);
            prostokat.Pole.Should().Be(20);
            prostokat.Obwod.Should().Be(18);
        }
    }
}
