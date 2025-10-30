namespace Differenza
{
    internal class Program
    {
        static int QuadratoAB(int a, int b)
        {
            int S = 0;

            for(int i = a; i <= b; i++)
            {
                S = S + i * i;
            }

            return S;
        }
        static int QuadratoSomma(int a, int b)
        {
            int Quadratosomma = 0, somma = 0; 

            for(int i = a; i<= b; i++)
            {
                somma = somma + i;
            }

            Quadratosomma = somma * somma;

            return Quadratosomma;
        }
        static int Differenza(int a, int b)
        {
            int Diff = 0;

            Diff = QuadratoSomma(a, b) - QuadratoAB(a, b);

            return Diff;
        }
        static void Main(string[] args)
        {
            int differenza = 0;

            Console.WriteLine("Dimmi il primo numero");
            int a = Convert.ToInt32 (Console.ReadLine());

            Console.WriteLine("Dimmi il secondo numero");
            int b = Convert.ToInt32 (Console.ReadLine());

            Console.WriteLine("la differenza è " + Differenza(a, b));
        }
    }
}
