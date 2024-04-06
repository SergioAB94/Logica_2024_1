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
            switch (numJugadores)
            {
                case 2:
                    numMax = 50;
                    break;
                case 3:
                    numMax = 100;
                    break;
                case 4:
                    numMax = 200;
                    break;
            }
            Random random = new Random();
            int numAzar = random.Next(numMax + 1);

            //iniciar el juego
            bool jugar = true;
            while (jugar)
            {
                //turnos de el juego
                for (int i = 1; i <= numJugadores; i++) 
                {
                    Console.WriteLine("Turno jugador {0}: ", i);
                    int intento = int.Parse(Console.ReadLine());

                    if (intento == numAzar)
                    {
                        Console.WriteLine("Ganaste");
                        jugar = false;
                        break;
                    }
                    else if (intento > numAzar)
                    {
                        Console.WriteLine("MENOR");
                    }
                    else
                    {
                        Console.WriteLine("Mayor");
                    }
                    //preguntar si desean otro tirito
                    if (jugar)
                }
            }
        }
    }
}
