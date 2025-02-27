using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CBookCard book = new CBookCard("Автор", "Заглавие", "Издательство", 2022, 228, 2077);
            book.Rating = 85;  
            book.Comment = "Читать всегда надо"; 

            Console.WriteLine(book.GetBookInfo());

            Console.ReadKey();


        }
    }
}
