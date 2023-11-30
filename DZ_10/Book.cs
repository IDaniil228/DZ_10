using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DZ_10
{
    internal class Book
    {
        private string title;
        private string author;
        private string publishing;

        public string Author
        {
            get { return author; }
        }
        public string Title
        {
            get { return title; }
        }
        public string Publishing
        {
            get { return publishing; }
        }

        public Book(string author, string title, string publishing)
        {
            this.author = author;
            this.title = title;
            this.publishing = publishing;
        }
        /// <summary>
        /// Выводит информацию о книге 
        /// </summary>
        public void ShowBook()
        {
            Console.WriteLine($"Автор - {author}, название - {title}, издательство - {publishing}");
        }
        public static int SortByTitle(Book book_1, Book book_2)
        {
            return string.Compare(book_1.Title, book_2.Title);
        }
        public static int SortByAuthor(Book book_1, Book book_2)
        {
            return string.Compare(book_1.Author, book_2.Author);
        }
        public static int SortByPublishing(Book book_1, Book book_2)
        {
            return string.Compare(book_1.Publishing, book_2.Publishing);
        }
    }
}
