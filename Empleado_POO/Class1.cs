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

    }
}
