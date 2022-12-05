using System;

namespace Open_Lab_10._03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Book LOTR = new Book();
            LOTR.Title = "The Lord of the Rings";
            LOTR.Pages = 9250;
            LOTR.Category = "epic high-fantasy novel";
            LOTR.Author = "John Ronald Reuel Tolkien";
            LOTR.ReleaseDate = 1954;

            LOTR.ans();
        }
    }
}