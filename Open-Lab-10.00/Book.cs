using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Open_Lab_10._00
{
    internal class Book
    {  
     private string title;
     private int pages;
     private string category;
     private string author;
     private string releaseDate;

         public void title_write(string title)
        {
            this.title = title;
        }
         public void pages_write(int pages)
        {
            this.pages = pages;
        }
         public void category_write(string category)
        {
            this.category = category;
        }
        public void author_write(string author)
        {
            this.author = author;
        }
        public void releaseDate_write(int releaseDate)
        {
            this.releaseDate = releaseDate;
        }
        public void write_fields()
        {
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Pages: " + pages);
            Console.WriteLine("Category: " + category);
            Console.WriteLine("Author: " + author);
            Console.WriteLine("releaseDate: " + releaseDate);
        }


    }
}  
