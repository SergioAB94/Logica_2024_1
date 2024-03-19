namespace Ejercicio16_CicloForNumeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int acumuladorPar = 0, acumuladorImpar  = 0;

            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine(i);

                if (i % 2 == 0) acumuladorPar += i;
                else acumuladorImpar += i;
            }
        }
    }
}
