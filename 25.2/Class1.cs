using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25._2
{
    internal class  Software
    {
        public string name;
        public string manufacturer;
        public bool paid;

        public string Name
        {
            get { return name; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    name = value; 
                else
                    Console.WriteLine("Введите название");
            }
        }

        public string Manufacturer
        {
            get { return manufacturer; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    manufacturer = value; 
                else
                    Console.WriteLine("Неизвестный производитель");
            }
        }

        public bool Paid
        {
            get { return paid; }
            set { paid = value; }
        }

        public Software()
        {
            name = "Неизвестно";
            manufacturer = "Неизвестно";
            paid = false;
        }

        public Software(string name, string manufacturer, bool isPaid)
        {
            this.name = name;
            this.manufacturer = manufacturer;
            this.paid = isPaid;
        }

        public override string ToString()
        {
            string type = paid ? "Платное" : "Бесплатное";
            return $"Название: {name}, Производитель: {manufacturer}, Тип: {type}";
        }

        public void PaidStatus()
        {
            paid = !paid;
        }

        public bool IsFreeSoft(string targetManufacturer)
        {
            return !paid && manufacturer.Equals(targetManufacturer, StringComparison.OrdinalIgnoreCase);
        }
    }
}
