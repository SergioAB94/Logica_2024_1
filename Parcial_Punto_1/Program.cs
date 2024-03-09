namespace Parcial_Punto_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables
            double sueldobasico = 2000000;
            double venta1, venta2, venta3;

            //cuanto valio cada venta
            Console.WriteLine("ingrese el valor de venta1: ");
            venta1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("ingrese el valor de venta2: ");
            venta2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("ingrese el valor de venta3: ");
            venta3 = Convert.ToDouble(Console.ReadLine());

            //Calcular el valor de las comisiones
            double comisionventa1 = venta1 * 0.10;
            double comisionventa2 = venta2 * 0.10;
            double comisionventa3 = venta3 * 0.10;

            //calcular sueldo del mes
            double totalComisiones = comisionventa1 + comisionventa2 + comisionventa3;
            double sueldoTotal = comisionventa1 + comisionventa2 + comisionventa3 + sueldobasico;

            Console.WriteLine(totalComisiones);
            Console.WriteLine(sueldoTotal);

            //Calcular promedio de comisiones
            double promedioComisiones = totalComisiones / 3;
            Console.WriteLine(promedioComisiones);

            //calcular si gano el beneficio extra
            string mensaje;
            if (totalComisiones > 1000000)
            {
                mensaje= "ganaste el beneficio extra";
            }
            else
            {
                mensaje= "No alcanzaste el benficio extra";
            }
                


        }
    }
}
