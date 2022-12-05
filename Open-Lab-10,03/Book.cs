using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Open_Lab_10._03
{
    internal class Book
    {
        private string title;
        private int pages;
        private string category;
        private string author;
        private int releaseDate;

        public string Title
        { get { return title; } set { title= value; } }

        public int Pages
        { get { return pages; } set { pages= value; } }

        public string Category
        { get { return category; } set { category= value; } }

        public int ReleaseDate
        {
            get => releaseDate;
            set
            {
                if ((value >= 2021) || (value <= 1450))
                {
                    releaseDate = -1;
                }
                else
                {
                    releaseDate = value;
                }
            }

        }

        public string Author
        { get { return author; } set { author= value; } }

        public void ans()
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Title :        " + title);
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Pages :        " + pages);
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Category :     " + category);
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Author :       " + author);
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Release Date : " + releaseDate);
            Console.WriteLine("----------------------------------------");
        }

    }
}
