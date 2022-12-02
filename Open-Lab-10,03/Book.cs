using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        public string Title(string strtitle)
        {
            this.title = strtitle;
            return strtitle;
        }

        public int Pages(int intpages)
        {
            this.pages = intpages;
            return intpages;
        }

        public string Category(string strcategory)
        {
            this.category = strcategory;
            return strcategory;
        }

        public string Author(string strauthor)
        {
            this.author = strauthor;
            return strauthor;
        }

        public int ReleaseDate(int intreleaseDate)
        {
            this.releaseDate = intreleaseDate;
            return intreleaseDate;
        }

        public void ans()
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Title :        " + Title(title));
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Pages :        " + Pages(pages));
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Category :     " + Category(category));
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Author :       " + Author(author));
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Release Date : " + ReleaseDate(releaseDate));
            Console.WriteLine("----------------------------------------");
        }

    }
}
