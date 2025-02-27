using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25._3
{
    internal class CBookCard
    {
        private string author;
        private string title;
        private string publisher;
        private int yearOfPublication;
        private int pageCount;
        private int circulation;
        private int rating;
        private string comment;

        public CBookCard(string author, string title, string publisher, int yearOfPublication, int pageCount, int circulation)
        {
            this.author = author;
            this.title = title;
            this.publisher = publisher;
            this.yearOfPublication = yearOfPublication;
            this.pageCount = pageCount;
            this.circulation = circulation;
            this.rating = 0; 
            this.comment = string.Empty; 
        }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Publisher
        {
            get { return publisher; }
            set { publisher = value; }
        }

        public int YearOfPublication
        {
            get { return yearOfPublication; }
            set { yearOfPublication = value; }
        }

        public int PageCount
        {
            get { return pageCount; }
            set { pageCount = value; }
        }

        public int Circulation
        {
            get { return circulation; }
            set { circulation = value; }
        }

        public int Rating
        {
            get { return rating; }
            set
            {
                if (value >= 0 && value <= 100) 
                    rating = value;
                else
                    throw new ArgumentException("Рейтинг должен быть в диапазоне от 0 до 100.");
            }
        }

        public string Comment
        {
            get { return comment; }
            set { comment = value; }
        }

        public string GetBookInfo()
        {
            return $"Автор: {author}\n" +
                   $"Заглавие: {title}\n" +
                   $"Издательство: {publisher}\n" +
                   $"Год издания: {yearOfPublication}\n" +
                   $"Число страниц: {pageCount}\n" +
                   $"Тираж: {circulation} : Рейтинг: {rating}\n" +
                   $"Комментарий: {comment}";
        }

    }
}
