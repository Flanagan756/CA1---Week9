using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA1___Week9
{
    class Program 
    {
        static void Main(string[] args)
        {
            //Created Objectes
            Book bk1 = new Book("Ulysses", "James Joyce", "1922,02,02", 730, Genre.Literature);
            Book bk2 = new Book("The C Programming Language", "B Kernighan and D Ritchie", "1978,02,28", 279, Genre.Computing);
            Book bk3 = new Book("Steve Jobs", "Walter Isaacson", "1978/10/24", 627, Genre.Biography);
            Book bk4 = new Book("The Hobbit", "JRR Tolkien", "1937/09/21", 310, Genre.Fiction);
            Book bk5 = new Book("Portrait of the Artist", "James Joyce", "1916,12,29", 299, Genre.Literature);

            //List
            List<Book> ReadingList = new List<Book>();
            //adds each book to the list
            ReadingList.Add(bk1);
            ReadingList.Add(bk2);
            ReadingList.Add(bk3);
            ReadingList.Add(bk4);
            ReadingList.Add(bk5);

            //Putting Books into an Array
            Book[] allBooks = new Book[5];
            allBooks[0] = bk1;
            allBooks[1] = bk2;
            allBooks[2] = bk3;
            allBooks[3] = bk4;
            allBooks[4] = bk5;


            Console.WriteLine("Author         Title       Pages      Genre      Publication Date");

            //Display Books
            Display(ReadingList);
            Console.WriteLine();

            //sort by author
            Array.Sort(allBooks);
            Console.WriteLine("Sorting the Reading list by Author");
            Console.WriteLine();
            Console.WriteLine("Author         Title       Pages      Genre      Publication Date");

            //DisplayBooks
            Display(ReadingList);

        }
        //Method to diplay the list of books
        private static void Display(List<Book> books)
        {
            foreach (Book book in books)
            {
                Console.WriteLine("{0,-15}", book);
            }
        }

     

    }
}
