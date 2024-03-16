namespace Ejercicio20_MenuCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Realice un programa que solicite dos números, luego debe pedirse un número que seleccionará alguna operación aritmética desde un menú. Si introduce 1 los números se deben sumar, si introduce 2 los números se deben restar, si es 3 los números se multiplican y si introduce 4 los números se dividen (validar división por cero). Independientemente de la selección, imprima el resultado. Además, el programa debe tener la posibilidad de volver al menú para pedir 2 nuevos números y hacer la elección de la operación aritmética o digitar cero para finalizar el programa

            int option;
            double suma, resta, producto, cociente, num1, num2;
            // flag para volver o salir del programa
            bool exit = false;

            Console.Write("INGRSE LOS DOS NUMEROS");
            num1 = Convert.ToInt32(Console.ReadLine()); 
            num2 = Convert.ToInt32(Console.ReadLine());

            do
            {

                Console.WriteLine("\n|----MENU OPERACIONES ARITMETICAS-----|");
                Console.WriteLine("|Seleccione una operacion aritmetica para sus numeros");
                Console.WriteLine("|---------------------|");
                Console.WriteLine("|1. SUMA              |");
                Console.WriteLine("|2. RESTA             |");
                Console.WriteLine("|3. MULTIPLICACION    |");
                Console.WriteLine("|4. DIVISION          |");
                Console.WriteLine("|---------------------|");
                Console.WriteLine("|DIGITE 0 PARA SALIR--|\n");

                option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 0:
                        exit = true;
                        break;
                    case 1:
                        suma = num1 + num2;
                        Console.WriteLine(string.Format("{0} + {1} = {2}", num1, num2, suma));
                        break;

                    case 2:
                        resta = num1 - num2;
                        Console.WriteLine(string.Format("{0} - {1} = {2}", num1, num2, resta));
                        break;

                    case 3:
                        producto = num1 * num2;
                        Console.WriteLine(string.Format("{0} * {1} = {2}", num1, num2, producto));
                        break;

                    case 4:
                        if (num2 != 0)
                        {
                            cociente = num1 / num2;
                            Console.WriteLine(string.Format("{0} / {1} = {2}", num1, num2, cociente));
                        }
                        else
                        {
                            Console.WriteLine("No se puede dividir por cero");
                        }
                        break;

                    default:
                        Console.WriteLine($"la opcion {option} no es valida. Digite una opcion valida");
                        break;

                }

            }
            while (!exit);

        }
    }
}
