using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25._1
{
    internal class Edition
    {

        string name;
        string surname;
        int year;

        public string Name
        {
            get { return (name != "") ? name : "неизвестно"; }
            set => name = value;
        }
        public string Surname
        {
            get { return (surname != "") ? surname : "неизвестно"; }
            set => surname = value;
        }
        public int Year
        {
            get { return (year != 0) ? year : 0; }
            set
            {
                if (value < 1990)
                {
                    year = 1990;
                }
                else if (value > 2024)
                {
                    year = 2024;
                }
                else
                {
                    year = value;
                }
            }
        }

        public Edition() { }

        public Edition(string name, string surname, int year)
        {
            this.Name = name;
            this.Surname = surname;
            this.Year = year;
        }

        public int ChangePublicationYearRange(int year)
        {
            if (year > 1990 && year < 2024)
            {
                return year;
            }
            else
            {
                year = 2000;
            }
            return year;
        }

        public string FallIntoYear(int year)
        {
            if (year > 1990 && year < 2024)
            {
                return "Попадает в интервал";
            }
            else
            {
                return "Не попадает в интервал";
            }
        }

        public override string ToString()
        {
            return $"Name = {Name}, Surname = {Surname}, Year = {Year}";
        }
    }
}
