using System;

namespace BooksLibraryProject1
{
    public class Book
    {
        string title;
        string author;
        int pageNumber;
        string isbn13;

        public string Ttle { get => title; }
        public string Author { get => author; }
        public int PageNumber { get => pageNumber; }
        public string Isbn13 { get => Isbn13; }


        public Book(string title, string author, int pageNumber, string isbn13)
        {
            Validation(title, author, PageNumber, isbn13);
        }
        public Book()
        {

        }
        public void Validation(string title, string author, int pageNumber, string isbn13)
        {
            if (title.Length > 2)
                this.title = title;
            else
                throw new ArgumentException("Title should be at least 2 character long.");
            if (pageNumber > 10 && pageNumber <= 1000)
                this.pageNumber = pageNumber;
            else
                throw new ArgumentException("PageNumber should between 10 and 1000.");
            if (isbn13.Length == 13)
                this.isbn13 = isbn13;
            else
                throw new ArgumentException("isbn must be 13 character long.");
            this.author = author;
        }
    }
}
