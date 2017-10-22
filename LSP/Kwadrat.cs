namespace LSP
{
    public class Kwadrat : Prostokat
    {
        private int a { get; }
        public Kwadrat(int k) : base(k, k)
        { 
            a = k;
        }

        public int Pole => a * a;
        public int Obwod => 4 * a;
    }
}