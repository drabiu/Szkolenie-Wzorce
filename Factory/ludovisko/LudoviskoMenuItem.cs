namespace Jedzenie
{
    public class LudoviskoMenuItem : IMenuItem
    {
        public LudoviskoMenuItem(int number, string name)
        {
            Name = name;
            Number = number;
        }

        public string Name { get; }

        public int Number { get; }
    }
}