namespace Empleado_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //crear objeto 
            Empleado_POO.Empleado empleado1 = new Empleado("Andres", 20, 10, 5.5);

            //Mostrar informacion empleado
            empleado1.MostrarInformacion(); 
        }
    }
}
