using Jedzenie;

namespace Factory
{
    public class FlighweightFactory
    {
        public AbstractFactory CreateFactory(string place)
        {
            switch (place)
            {
                case "kantyna":
                    return new KantynaFactory();
                case "ludovisko":
                    return new LudoviskoFactory();
                case "novege":
                    return new NoVegeFactory();
            }

            return new NullableFactory();
        }
    }
}
