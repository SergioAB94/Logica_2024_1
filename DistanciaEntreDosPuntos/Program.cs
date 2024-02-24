namespace DistanciaEntreDosPuntos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //lea las coordenadas de 2 puntos y muestre la distancia entre ellos 

            //datos de entrada son 4 variables
            //declaracion de variables
            double x1 = 3, x2 = 1.5, y1 = 4, y2 = 2.5, distancia;

            //solicitud de datos por pantalla:
            Console.Write("Por favor digitar el x1: ");
            x1 = double.Parse(Console.ReadLine());

            Console.Write("Por favor digitar el y1: ");
            y1 = double.Parse(Console.ReadLine());

            Console.Write("Por favor digitar el x2: ");
            x2 = double.Parse(Console.ReadLine());

            Console.Write("Por favor digitar el y2: ");
            y2 = double.Parse(Console.ReadLine());

            //Proceso/Calculo:
            distancia = Math.Sqrt((Math.Pow(x2 - x1, 2)) + (Math.Pow(y2 - y1, 2)));

            //dato de salida:
            Console.WriteLine(String.Format("La distancia entre los pares ordenados ({0} , {1}) y ({2} , {3}) es = {4} ", x1, y1, x2, y2,
                distancia.ToString("N3")));

            //Cambios realizados 

        }
    }
}
