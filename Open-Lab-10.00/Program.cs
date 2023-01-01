using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Lab_10._00
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book LOTR = new Book();
            LOTR.title_write ("Lord of the rings");
            LOTR.pages_write (1178);
            LOTR.category_write ("heroic romance");
            LOTR.author_write ("JOHN ROLAND REUEL TOLKIEN");
            LOTR.releaseDate_write ("29.7.1954");
            LOTR.write_fields();
       



        }
    }
}
