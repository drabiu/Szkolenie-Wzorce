namespace LSP
{
    public class Prostokat
    {
        protected int a;
        protected int b;

        public Prostokat(int i, int i1)
        {
            a = i;
            b = i1;
        }

        public int Pole => a * b;
        public int Obwod => 2 * a + 2 * b;
    }
}