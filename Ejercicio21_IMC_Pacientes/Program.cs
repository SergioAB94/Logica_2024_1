namespace Ejercicio21_IMC_Pacientes
{
    internal class Program
    {
        static void Main(string[] args)

        // doeclarar las variables
        {
            double peso, altura, imc, altura2;
            
            
            
            {

                Console.WriteLine("Ingreso el peso del paciente en (k)g");
                peso = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la altura del paciente (m)");
                altura = double.Parse(Console.ReadLine());
                altura2 = altura * altura;

                // calcular el IMC

                imc = peso / altura2;

                if (imc < 18.5)
                {
                    Console.WriteLine("El imc es de " + imc + " el paciente esta con peso insuficiente");
                }
                else if (imc == 18.5 && imc < 24.9)
                {
                    Console.WriteLine("El imc es de " + imc + " el paciente esta en peso saludable");
                }
                else if (imc == 25.0 && imc < 29.9)
                {
                    Console.WriteLine("El imc es de " + imc + " el paciente se encuentra en sobre peso");
                }
                else
                {
                    Console.WriteLine("El imc es de " + imc + " el paciente se encuentra con obesidad");
                }

            }
             
            
        }
    }
}
