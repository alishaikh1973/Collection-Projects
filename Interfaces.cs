using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSPROJECT_TQ.Hashset
{
    public class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
    }

    public class CheckPrice : IComparer<Product>
    {
        public int Compare(Product x, Product y)// x=p1, y=p2
        {
            if (x.Price > y.Price)
            {
                return 1;
            }
            else if (x.Price < y.Price)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product { Name = "Hp Laptop", Price = 38000 };
            Product p2 = new Product { Name = "Dell Laptop", Price = 38000 };

            CheckPrice c = new CheckPrice();

            int result = c.Compare(p1, p2);
            if (result == 1)
            {
                Console.WriteLine("Hp laptop has higher price than dell");
            }
            else if (result == -1)
            {
                Console.WriteLine("Hp laptop has less price than dell");
            }
            else
            {
                Console.WriteLine("Hp & Dell loptop has equal price");
            }
        }
    }
}







    
    
    
       