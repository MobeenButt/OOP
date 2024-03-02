using System;
using System.Collections.Generic;

namespace LBMS
{
    internal class Book
    {
        private string name;
        private string title;
        private int price;
        private List<Author> authors;
        public Book()
        {
           
        }
        public Book(string name, string title, int price)
        {
            this.name = name;
            this.title = title;
            this.price = price;
        }
        public string GetName()
        {
            return name;
        }
        public string GetTitle()
        {
            return title;
        }
        public int GetPrice()
        {
            return price;
        }
        public void SetPrice(int price)
        {
            this.price = price;
        }
        public void SetName(string Name)
        {
            name = Name;
        }
        public void AddAuthor(Author a)
        {
            if (authors != null)
            {
                authors.Add(a);
            }
           
        }
    }
}
