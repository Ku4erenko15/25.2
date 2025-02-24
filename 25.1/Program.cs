using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            Edition edition = new Edition();
            Console.WriteLine(edition.ToString());
            
            Edition edition2 = new Edition("Лев", "Николаевич", 1908);
            Console.WriteLine(edition2.ToString());
           
            Console.WriteLine("Введите имя");
            string name = Console.ReadLine();
            Console.WriteLine("Введите Фамилию");
            string surname = Console.ReadLine();
            Console.WriteLine("Введите год издания");
            int year = int.Parse(Console.ReadLine());
            Edition edition3 = new Edition(name, surname, year);
            Console.WriteLine($"{edition3.ToString()}\n{edition3.ChangePublicationYearRange(year)}\n{edition3.FallIntoYear(year)}");
        
        }
    }
}
