using Ejercicio36_POO_vet;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Crear un programa con POO de un centro veterinario donde me muestre un menú con las siguientes opciones: Comprar, Adoptar, Regalar.

            Si el usuario elige “Comprar”, entonces debe mostrar un menú con 5 razas diferentes para ser elegida por ese comprador, y luego mostrar la raza con su precio. (Usted es libre de elegir esas 5 razas y el valor de cada una de ellas)

            Si el usuario elige “Adoptar”, debe pedir la raza y mostrar por pantalla un mensaje de agradecimiento por adoptar una mascota

            Si el usuario elige “Regalar”, entonces pedir por pantalla el nombre de la mascota, edad, raza y peso que va a regalar. Mostrar un mensaje de agradecimient*/

            //creamos la instancia de la clase Vet_Center
            Vet_Center vet_Center = new Vet_Center();

            //Aqui estamos invocando el metodo
            vet_Center.ShowMenu();


        }
    }
}
