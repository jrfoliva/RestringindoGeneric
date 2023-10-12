using RestringindoGeneric.Entities;
using RestringindoGeneric.Services;
using System.Globalization;

namespace RestringindoGeneric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter with the Quantity: ");
            int qty = Convert.ToInt32(Console.ReadLine());
            
            // Criar lista 
            List<Product> products = new List<Product>();
            for(int i = 1; i <= qty; i++) 
            {
                Console.Write($"{i}#: ");
                string[] aux = Console.ReadLine().Split(",");
                products.Add(new Product(aux[0], Convert.ToDouble(aux[1], CultureInfo.InvariantCulture)));
            }

            // Verificar o maior
            CalculationService cs = new CalculationService();
            Product max = cs.Max(products);

            Console.WriteLine("Most expensive: ");
            Console.WriteLine(max);
        }
    }
}