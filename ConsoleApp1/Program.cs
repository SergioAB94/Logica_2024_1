namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Cantidad de jugadores
            int numJugadores = 0;

            do
            {
                Console.WriteLine("Ingrese el numero de jugadores entre 2-4: ");
                numJugadores = int.Parse(Console.ReadLine());
            } while (numJugadores < 2 || numJugadores > 4);

            //generar un numero al azar segun la cantidad de jugadores
            int numMax = 0;
        }
    }
}
