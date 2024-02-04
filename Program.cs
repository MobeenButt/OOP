using System;

namespace Product_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            int op;
            do
            {
                op = product.MENU();
                if (op == 1)
                {
                    Console.Clear();
                    product.AddProduct();
                }
                else if (op == 2)
                {
                    Console.Clear();
                    product.SHOWPRODUCTS();
                }
                else if (op == 3)
                {
                    Console.Clear();
                    product.TOTAL();
                }
                else if (op == 4)
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Invalid Choice...");
                }
            } while (op != 4);
        }
    }
}
