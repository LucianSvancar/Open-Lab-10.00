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
            LOTR.title = "Lord of the rings";
            Console.WriteLine("THE TITLE OF BOOK IS: " + LOTR.title);
        }
    }
}
