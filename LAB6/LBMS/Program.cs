using System;
using System.Collections.Generic;

namespace LBMS
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
            Author author1 = new Author("Mobeen Butt", "mobeen914butt@gmail.com");
            Book book1 = new Book("Book 1", "1 Title", 20);
            book1.AddAuthor(author1);
            Console.WriteLine("Book 1 Details:");
            Console.WriteLine($"Book Name: {book1.GetName()}");
            Console.WriteLine($"Book Title: {book1.GetTitle()}");
            Console.WriteLine($"Book Price: {book1.GetPrice()}");
            Console.WriteLine("\nAuthors of Book 1:");
            Console.WriteLine($"Author Name: {author1.GetName()}");
            
            Console.WriteLine($"Author Email: {author1.GetEmail()}");
            author1.SetEmail("my email.com");
            Console.WriteLine($"Author Email: {author1.GetEmail()} ");


            Console.ReadKey();


        }
    }

}