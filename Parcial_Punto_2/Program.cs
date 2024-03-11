using System;

namespace Parcial_Punto_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //definir variables:
            double velocidadTren1 = 80;
            double velocidadTren2 = 110;

            double tiempoInicial = 1;

            double distanciaEntreTrenes = velocidadTren1 * tiempoInicial;

            double tiempoAlcance = distanciaEntreTrenes / (velocidadTren2 - velocidadTren1);

            double tiempoEncuentro = tiempoAlcance + 10;

            Console.WriteLine($"El segundo tren alcanzará al primer tren a las {tiempoEncuentro}");




          //  double trainSpeed1 = 80;
          //  double trainSpeed2 = 100;

          //  double initialTime = 1;

          //  double distanceBetweenTrains = trainSpeed1 * initialTime;
          
          //  double timeToCatchUp = distanceBetweenTrains / (trainSpeed2 - trainSpeed1);

          //  double catchUpTime = timeToCatchUp + 10;
          //  Console.WriteLine($"El segundo tren alcanzará al primer tren a las {catchUpTime}");
        }
    }
}

