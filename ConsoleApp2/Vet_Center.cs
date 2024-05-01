namespace Ejercicio36_POO_vet
{
    public class Vet_Center
    {
        public Vet_Center()
        {
             
        }

        #region Methods 

        public void ShowMenu()
        {
            //Declaracion de variables locales
            int option;

            Console.WriteLine("Bienvenido a Vet_Center");
            Console.WriteLine("-----------------------");
            Console.WriteLine("Seleccione una opcion--");
            Console.WriteLine("1. Comprar             ");
            Console.WriteLine("2. Adoptar"             );
            Console.WriteLine("3. Regalar             ");
            option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1: //Comprar una mascota
                    BuyPet();
                    break;

                case 2:// Adoptar mascota
                    AdoptPet();
                    break;

                case 3:// Regalar mascota
                    GivePet();
                    break;

            }
        }

        private void BuyPet()
        {

            Console.WriteLine("---Razas Disponibles----");
            Console.WriteLine("----------------------- ");
            Console.WriteLine("Seleccione una raza:--- ");
            Console.WriteLine("1. PastorAleman $15.000 ");
            Console.WriteLine("2. PitBull      $30.000 ");
            Console.WriteLine("3. Salchicha    $25.000 ");
            Console.WriteLine("3. Golden       $10.000 ");
            Console.WriteLine("3. BullDog      $5.000  ");
            int breedOption = Convert.ToInt32(Console.ReadLine());

            switch (breedOption)
            {
                case 1:
                    Console.WriteLine("Felicitaciones compraste un PastorAleman");
                    break;

                case 2:
                    Console.WriteLine("Felicitaciones compraste un PittBull");
                    break;

                case 3:
                    Console.WriteLine("Felicitaciones compraste un Salchicha");
                    break;
                case 4:
                    Console.WriteLine("Felicitaciones compraste un Golden");
                    break;

                case 5:
                    Console.WriteLine("Felicitaciones compraste un BullDog");
                    break;
                }
            }
        private void AdoptPet()
        {
                Console.WriteLine("Ingrese la raza que desea adoptar");
                string breed = Console.ReadLine();

                Console.WriteLine(string.Format("Gracias por adoptar un {0}.", breed));
        }
        private void GivePet()
        {
                Console.Write("ingrese el nombre de la mascota");
                string name = Console.ReadLine();   
                Console.Write("ingrese la edad");
                int age = Convert.ToInt32(Console.ReadLine());
                Console.Write("ingrese la raza");
                string breed = Console.ReadLine();
                Console.Write("ingrese el peso");
                double weight = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(string.Format(" gracias por regalar a {0}, de {1} años, de raza{2}, y con un peso de {3} Kg", name, age, breed, weight));
        }



        #endregion
    }
}
