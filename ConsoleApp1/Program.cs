namespace ConsoleApp1
{
   
        public class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }
        }

        public class Program
        {
            public static void Main(string[] args)
            {
                // Create an array to hold the books
                Book[] books = new Book[2];
              Book book1 = new Book();
            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine($"Information of book {i+1}:");
                Console.Write($"Input name of the book{i+1}: ");
                book1.Title = Console.ReadLine();
                Console.Write($"Input the author{i+1}: ");
                book1.Author= Console.ReadLine();
                books[i]= book1;
            }
                

                // Display the information of the inserted books
                Console.WriteLine("\nExpected Output:");
                for (int i = 0; i < books.Length; i++)
                {
                    Book currentBook = books[i];
                    Console.WriteLine($"{i + 1}: Title = {currentBook.Title}, Author = {currentBook.Author}");
                }

                Console.ReadLine();
            }
        }
    }


