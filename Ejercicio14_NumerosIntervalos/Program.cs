using System;

namespace Ejercicio14_NumerosIntervalos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, numMenor, numMayor;
            
            Console.WriteLine("Ingrese el primer numero");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                numMenor = num2;
                numMayor = num1;
            }
            else
            {
                numMenor = num1;
                numMayor = num2;
            }

            for (int i = numMenor; i<numMayor; i++)
            {
                Console.WriteLine(i);
            }
        }



        
    }
}
