using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA1___Week9
{
    //enum
    enum Genre
    {
        Fiction,
        Biography,
        Computing,
        Literature
    }
    class Book: IComparable
    {
        //Properties
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime Published { get; set; }
        public int Pages { get; set; }

        public Genre Genre { get; set; }

        //Constructor
        public Book(string title, string author, string published, int pages, Genre genre)
        {
            //sets properties within default constructor
            Title = title;
            Author = author;
            Published = Convert.ToDateTime(published);
            Pages = pages;
            Genre = genre;
        }

        //Message formate overide to the string
        public override string ToString()
        {

            return (Author + "     " + Title + "     " + Pages + "     " + Genre + "     " + Published);
        }

        //Compares the authors within books
        public int CompareTo(object obj)
        {
            Book that = (Book)obj;

            return this.Author.CompareTo(that.Author);
        }



        }
    }
