using System.Diagnostics.CodeAnalysis;

namespace MyFirstArray
{
    public class Program
    {
        private static void Main(string[] args)
        {
            //Desarrole un algoritmo que almacene las ventas que obtuvo mensualmente un almacen durante el año 2023. Mostrar en pantalla el total de ventas.

            string[] months = new string[] {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubere", "Noviemebre", "Diciembre"};

            decimal[] sales = new decimal[12];
            decimal sum = 0;

            #region Methods
            sales = GetSales(months, sales);
            sum = CalculateSales(sales, sum);
            ShowYearSale(sales, months, sum);
            #endregion
        }
        #region Methods
        private static decimal[] GetSales(string[] months, decimal[] sales)
        {
            for (int i = 0; i < months.Length; i++)
            {
                Console.WriteLine(string.Format("Ingrese las ventas del mes {0}", months[i]));
                sales[i] = Convert.ToDecimal(Console.ReadLine());
            }
            Console.WriteLine("\n");
            return sales;
        
        }

        private static decimal CalculateSales(decimal[] sales, decimal sum)
        {
            for (int i = 0;i < sales.Length; i++)
            {
                sum += sales[i];
            }
            return sum;
        }
        private static void ShowYearSale(decimal[] sales, string[] months, decimal sum)
        {
            for (int i = 0; i < sales.Length; i++)
            {
                Console.WriteLine($"{months[i]}: {sales[i]:C2}");
            }

            Console.WriteLine($"Total = {sum}");
        }
        #endregion
    }
    
}
