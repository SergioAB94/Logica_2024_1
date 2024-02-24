namespace MiPrimerAlgoritmo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;

            double exp, sqrt2, sqrt3;

            Console.WriteLine("ingrese el num1");
            Convert.ToInt32(Console.ReadLine());
            double el_doble_de = Math.Pow(8, 2);

            Console.WriteLine("ingrese el num2");
            Convert.ToInt32(Console.ReadLine());
            double raiz_cuadrada = Math.Sqrt(16);

            Console.WriteLine("ingrese el num3");
            Convert.ToInt32(Console.ReadLine());
            double raiz_cubica = Math.Cbrt(27);

            Console.WriteLine("el doble de" + "num1," + "es:" + Math.Pow(8, 2));
            Console.WriteLine("la raiz cuadrada de" + "num2," + "es:" + Math.Sqrt(16));
            Console.WriteLine("la raiz cubica de" + "num3," + "es:" + Math.Cbrt(27));

        }
    }
}
