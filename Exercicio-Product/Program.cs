using Exercicio_Product.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Product
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            List<Product> list = new List<Product>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Product #" + i + "data: ");
                Console.Write("Commom, used or imported (c/u/i)");
                char c = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (c == 'u')
                {
                    Console.Write("Manufacture date: (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, manufactureDate));
                    Console.WriteLine();

                }
                else if (c == 'i')
                {
                    Console.Write("Customs Fee: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new ImportedProduct(name, price, customsFee));
                    Console.WriteLine();
                }

                else
                {
                    list.Add(new Product(name, price));
                    Console.WriteLine();
                }
              

            }

            Console.WriteLine();
            Console.Write("PRICE TAGS: ");
            Console.WriteLine();
            foreach (Product obj in list)
            {
                Console.WriteLine(obj.PriceTag());
            }
        }
    }
}
