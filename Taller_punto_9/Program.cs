namespace Taller_punto_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //construir un programa que pida 3 números por pantalla y luego indique cual es el mayor de los numeros ingresados

            int num1, num2, num3;
            Console.WriteLine("Ingrese el primer numero: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero: ");
            num2 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Ingrese el tercer numero: ");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                    Console.WriteLine("el mayor numero es: {num1}");

                else
                    Console.WriteLine("el mayor numero es: {num3}");
            }
            else
            {
                if (num2 > num3)
                    Console.WriteLine("el mayor numero es: {num2}");

                else
                    Console.WriteLine("El mayor número es: {num3}");
            }
        }
    }
}
    

