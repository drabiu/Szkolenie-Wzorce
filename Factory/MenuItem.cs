namespace Jedzenie
{
    public class MenuItem : IMenuItem
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