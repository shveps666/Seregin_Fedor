using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание_4
{
    public class Book
    {
        private readonly string isbn;
        private string Title { get; set; }
        private string Author { get; set; }
        public Book(string isbn, string title, string author)
        {
            this.isbn = isbn;
            this.Title = title;
            this.Author = author;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"ISBN: {isbn}");
            Console.WriteLine($"Название: {Title}");
            Console.WriteLine($"Автор: {Author}");
        }
        public string ISBN
        {
            get { return isbn; }
        }
    }
    class Program
    {
        static void Main()
        {
            Book myBook = new Book("52342634572", "токийский гуль", "Лев Толстой");
            myBook.PrintInfo();
        }
    }
}
