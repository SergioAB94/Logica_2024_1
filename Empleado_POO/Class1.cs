using Empleado_POO;

namespace Empleado_POO
{
    public class Empleado
    {
        //Properties
        public string Nombre { get; set; }
        public int Edad {  get; set; }
        public int VentasMes {  get; set; }
        public double ValorVenta {  get; set; }

        //Methods 
        public Empleado(string nombre, int edad, int ventasMes, double valorVenta)
        {
            Nombre = nombre;
            Edad = edad;
            VentasMes = ventasMes;
            ValorVenta = valorVenta;

        }
        //Metodo para calcular ventas total del empleado durante el mes
        public double CalcularTotalVentas()
        {
            return VentasMes * ValorVenta;
        }
        //Metodo para mostrar la informacion del empleado
        public void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Edad: {Edad}");
            Console.WriteLine($"Total ventas mes: {CalcularTotalVentas()}");
        }
    }
}class Program
{
    static void Main(string[] args )
    {
        //crear objeto 
        Empleado_POO.Empleado empleado1 = new Empleado ("Andres", 20, 10, 5.5);

        //Mostrar informacion empleado
        empleado1.MostrarInformacion();
    }
}
