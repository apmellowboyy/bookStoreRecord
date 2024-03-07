using System;
namespace bruh
{
    class Program
    {
        public record Bookstore(string Title, string Author, double Price);
        public static void Main()
        {
            Bookstore Bookstore = new("Holes", "Louis Sachar", 4.99);
            Console.WriteLine(Bookstore);

            Bookstore yerddd = new("Attack on Titan", "Hajime Isayama", 5.99);
            Console.WriteLine(yerddd);

            Bookstore cmonDawg = new("The Hunger Games", "Suzanne Collins", 7.99);
        }
    }
}