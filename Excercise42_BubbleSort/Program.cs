namespace Excercise42_BubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Realizar un algoritmo que me pida por pantalla la cantidad de números naturales que desea ingresar para guardarlos en un array. Luego de conocer la longitud del array y llenarlo con los números, el algoritmo deberá ordenarlos con el método de bubble sort. Mostrar en pantalla el arreglo ordenado ascendentemente (menor a mayor).

            // n=5 [5, 2, 8, 1, 9]
            // mostrar: [1, 2, 5, 8, 9]

            //Declaracion de variables
            int n;

            Console.Write("Ingrese la cantidad de N: ");
            n = Convert.ToInt32(Console.ReadLine());

            //Declaracion e inicalizacion del Array Numbers
            int[] numbers = new int[n];

            
            //llenar el array 
            FillArray(numbers, n);

            //Ordenar Array con Bubble Sort
            BubbleSort(numbers, n); 

            //Mostrar Array ordenado
            ShowArray(numbers, n);

        }

        private static void FillArray(int[] numbers, int n)
        {
            //Con este for lleno mi array numbers
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Ingrese el numero en la posicion {i + 1}: "); //5 
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        private static void BubbleSort(int[] numbers, int n)
        {
            int aux = 0;
            for (int i = 0;i < n - 1; i++)
            {
                for (int j = 0; j < n - 1 - i;j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        aux = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = aux;

                    }
                }
            }
        }
        private static void ShowArray(int[] numbers, int n)
        {
            string split = " ";
            Console.Write("Array numbers sorted: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(String.Format("{0} {1}", numbers[i], split));
            }
        }

    }
}
