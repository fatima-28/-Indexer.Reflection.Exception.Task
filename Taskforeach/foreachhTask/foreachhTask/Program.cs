using System;

namespace TypeForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("lord of rings", 5);
            Book book2 = new Book("game of thrones", 12);
            book1.Method();
            book2.Method();
        }
    }
    public class Book
    {
        public string Name { get; set; }
        public int Price { get; set; }
        Book[] books = new Book[0];
        public Book(string name, int price)
        {
            Name = name;
            Price = price;
        }
        public void Method()
        {
            Book[] array = books;
            Array.Resize(ref books, books.Length + 1);
            books[books.Length - 1] = new Book();
            foreach (Book item in books)
            {
                Console.WriteLine(item);
            }
        }

    }
}
