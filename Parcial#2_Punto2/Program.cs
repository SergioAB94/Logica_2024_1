namespace Parcial_2_Punto2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Realizar un algoritmo en C# para una Natillera Navideña que determina cuánto ahorrará una persona en un año 2023, si al final de cada mes deposita cantidades variables de dinero; además, calcular los rendimientos generados por el ahorro en cada mes, correspondientes a la tasa del momento estipulada por Banco De La República (Tasas generadas por la clase llamada Random entre 0.1% y 5.0%). Si la tasa del mes es inferior al 1.5%, entonces la Natillera estará en capacidad de otorgarle un bono a esa persona correspondiente a 2/5 partes del ahorro de dicho mes.
 
           Se quiere saber cuál fue la tasa estipulada por el Banco de La República, cuánto lleva ahorrado, cuánto se otorgó de bono (si aplica) y cuánto lleva de rendimiento en cada mes, además se quiere saber el ahorro total, el bono total, los rendimientos totales al cabo de un año, y la suma total neta que se le consignará a esa persona.
 
           La aplicación debe tener la funcionalidad de preguntar al usuario si quiere volver al inicio para determinar el ahorro y rendimientos del siguiente año. Si no, salirse del programa. */

            //Determinamos Variables necesarias


            bool volver = true;
            const double BONO = 0.4; // SNAKE CASE : Notacion para Constantes. para el calculo de 2/5 = 0.4
            string continuar;

            //Sirve para que nuestra aplicacion vuelva a empezar para eso usamos el while

            while (volver)
            {
                //Variable para aportes tipo decimal (usada para valores monetarios)
                decimal aporteMensual, rendimientoMensual = 0, aporteTotal = 0, rendimientoTotal = 0, bonoMensual = 0, bonoTotal = 0, aporteTotalNeto, tasaMensual;


                //Clase Random (clase aleatoria) 
                Random random = new Random();   //Forma que permite instanciar una clase en objeto

                for (int mes = 1; mes <= 12; mes++)
                {
                    Console.WriteLine($"Ingrese la cantidad de dinero que desea ahorrar en el mes {mes}: ");
                    aporteMensual = Convert.ToDecimal(Console.ReadLine());

                    tasaMensual = (decimal)random.Next(1, 51) / 10;
                    rendimientoMensual = aporteMensual * (tasaMensual / 100);

                    if (tasaMensual < 1.5M) //M significa Money (dinero) y se coloca alli para que no genere error y haga la conversion
                    {
                        bonoMensual = aporteMensual * (decimal)BONO; // (decimal) es la forma abreviada de la conversion usada Convert.ToDecimal
                        bonoTotal += bonoMensual;

                    }
                    aporteTotal += aporteMensual;
                    rendimientoTotal += rendimientoMensual;
                    Console.WriteLine("----------------------------------");
                    Console.WriteLine($"Mes {mes}: \n" +
                                      $"Aportes: {aporteMensual}\n" +
                                      $"Tasa: {tasaMensual}\n" +
                                      $"Rendimientos: {rendimientoMensual}\n" +
                                      $"Bono: {bonoMensual}");
                    Console.WriteLine("__________________________________");
                }

                aporteTotalNeto = rendimientoTotal + aporteTotal + bonoTotal;
                Console.WriteLine("-------------------------------------");
                Console.WriteLine($"Aportes totales: {aporteTotal}\n" +
                                  $"Rendimientos Totales: {rendimientoTotal}\n" +
                                  $"Bonos Totales: {bonoTotal}\n" +
                                  "-------------------------------------\n" +
                                  $"TOTAL NETO:  {aporteTotalNeto}");
                Console.WriteLine("¿Desea Ingresar a la natillera para el siguiente año? (s/n)");
                continuar = Console.ReadLine().ToLower();
                if (continuar == "n") volver = false;

            }



        }
    }
}
        
    

