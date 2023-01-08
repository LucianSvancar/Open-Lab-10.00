using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Open_Lab_10._00
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Book LOTR = new Book();
            LOTR.Title = "Lord of the rings";
            LOTR.Pages = 1178;
            LOTR.Category ="heroic romanece";
            LOTR.Author = "John Ronald Reuel Tolkien";
            LOTR.ReleaseDate = 1954;
        
            Console.WriteLine("Title is: " + LOTR.Title);
            Console.WriteLine("Pages are: " + LOTR.Pages);
            Console.WriteLine("Category is: " + LOTR.Category);
            Console.WriteLine("Author is: " + LOTR.Author);
            Console.WriteLine("releaseDate is: " + LOTR.ReleaseDate);
            Book LOTR2 = new Book();
            Book LOTR3 = new Book("Lord of the rings 3", 416 );
            Book HOBIT = new Book("The Hobbit", 304 , "fantasy novel", "John Ronald Reuel Tolkien", 1937);
            LOTR2.write_fields();
            LOTR3.write_fields();
            HOBIT.write_fields();


        }
    }
}
