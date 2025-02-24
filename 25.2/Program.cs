using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25._2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Software software1 = new Software("Windows", "Microsoft", true);
            Console.WriteLine(software1.ToString());
            software1.PaidStatus();
            Console.WriteLine("После изменения статуса:");
            Console.WriteLine(software1.ToString());

            Software software2 = new Software();
            software2.name = "Linux";
            software2.manufacturer = "Open Source";
            software2.paid = false;
            Console.WriteLine(software2.ToString());

            Software software3 = new Software("Photoshop", "Adobe", true);
            Console.WriteLine(software3.ToString());

            Console.WriteLine("Введите название ПО:");
            string name = Console.ReadLine();
            Console.WriteLine("Введите производителя:");
            string manufacturer = Console.ReadLine();
            Console.WriteLine("Платное ли ПО? (true/false):");
            bool isPaid = bool.Parse(Console.ReadLine());
            Software software4 = new Software(name, manufacturer, isPaid);
            Console.WriteLine(software4.ToString());

            Console.WriteLine("Является ли Linux бесплатным продуктом Open Source? " + software2.IsFreeSoft("Open Source"));
        

        Console.ReadKey();
        }
    }
}
