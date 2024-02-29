namespace Taller_punto_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escribir un algoritmo que dados 2 valores de entrada imprima siempre la división del mayor entre el menor.
            //Validar indeterminación.

            //declarar variables:
            double num1, num2;

            //Escriba el primer numero
            Console.WriteLine("Ingrese el primer numero: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            // Validamos la indeterminacion:
            if (num2 == 0)
            {
                Console.WriteLine("Error: La división por cero no está definida.");
            }
            else
            {

                //validar cual de los dos es mayor:

                double mayor = Math.Max(num1, num2);
                double menor = Math.Min(num1, num2);

                //realizar la division del mayor entre el menor:
                double resultado = mayor / menor;

                //mostrar el resultado:
                Console.WriteLine("La division del mayor entre el menor es: " + resultado);


            }
        }
    }
}
