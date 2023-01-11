using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Schema;
using static System.Net.Mime.MediaTypeNames;

namespace Open_Lab_10._00
{
    internal class Book
    {  
     private string title;
     private int pages;
     private string category;
     private string author;
     private int releaseDate;

        public string Title
        {
           get { return title; }
           set { title = value; }
        }
        public int Pages
        {
            get { return pages; }
            set
            {

                if (value<= 0 )
                {
                    pages = 1;
                }

                else
                {
                    pages = value;
                }
            }
        }
        public string Category
        {
          
           set { category = value; }
        }
        public string Author
        {
            get { return author; }
           set { author = value; }
        }
        public int ReleaseDate
        {
            get { return releaseDate;}
            set
            {
               if ( value < 1450 || value > 2021)  
               {  releaseDate = -1;
               }
               else
               {
                  releaseDate = value;
               }
            }
        }
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
        public Book() 
        { title = "-1";
          pages = -1;
          category = "-1";
          author = "-1";
          releaseDate = -1;        
        }
        public Book(string title , int pages) 
        {
          category = "-1";
          author = "-1";
          releaseDate = -1;  
          this.title = title;
          this.pages = pages;
        }
        public Book(string title, int pages, string author, string category, int releaseDate)
        {
          this.title = title;
          this.pages = pages;
          this.author = author;
          this.category = category;
          this.releaseDate =releaseDate;
        }
      
        
        ///Tento zoznam obsahuje kategórie pre knihy(Len pre autora)
       
        public static List<string> categoryList = new List<string>()
        {"For kids", "Romantic", "Science fiction", "Adventurous", "Academically" };
    }
}  
