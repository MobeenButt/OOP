using System;
using System.Collections.Generic;

namespace Product_System
{
    internal class Product
    {
        public List<Product> products = new List<Product>();
        public int Id;
        public string Name;
        public float Price;
        public string Category;
        public string BrandName;
        public string Country;

        public Product()
        {

        }
        public Product(int Id, string Name, float Price, string Category, string BrandName, string Country)
        {
            this.Id = Id;
            this.Name = Name;
            this.Price = Price;
            this.Category = Category;
            this.BrandName = BrandName;
            this.Country = Country;
        }
        public int MENU()
        {
            int op;
            Console.WriteLine("\t\t\t\tPRODUCT MANAGEMENT SYSTEM");
            Console.WriteLine("1. Add Products");
            Console.WriteLine("2. Show Products");
            Console.WriteLine("3. Total Store Worth");
            Console.WriteLine("4. Exit");
            Console.WriteLine("Enter your Choice...");
            op = int.Parse(Console.ReadLine());
            return op;
        }
        public void AddProduct()
        {
            Console.Clear();
            Console.WriteLine("Enter Product Details:");
            Console.Write("ID: ");
            int Id = int.Parse(Console.ReadLine());
            Console.Write("Name: ");
            string Name = Console.ReadLine();
            Console.Write("Price: ");
            float Price = float.Parse(Console.ReadLine());
            Console.Write("Category: ");
            string Category = Console.ReadLine();
            Console.Write("BrandName: ");
            string BrandName = Console.ReadLine();
            Console.Write("Country: ");
            string Country = Console.ReadLine();
            Product newproduct = new Product(Id, Name, Price, Category, BrandName, Country);
            products.Add(newproduct);
            Console.WriteLine("Product Added Successfully! ");
            Console.ReadLine();
            Console.Clear();
        }
        public void SHOWPRODUCTS()
        {

            Console.Clear();
            Console.WriteLine("\t\t\tList of Products: ");
            foreach (Product product in products)
            {
                Console.WriteLine("Id: {0}\t\tName: {1}\t\tPrice: {2}\t\tCategory: {3}\t\tBrandName: {4}\t\tCountry: {5}", product.Id, product.Name, product.Price, product.Category, product.BrandName, product.Country);
            }
            Console.ReadLine();
            Console.Clear();
        }
       public void TOTAL()
        {
            Console.Clear();
            float sum = 0;
            foreach (Product product in products)
            {
                sum += product.Price;
            }
            Console.WriteLine("Total Store Worth: {0}", sum);
            Console.ReadLine();
            Console.Clear();
        }
    }
}
