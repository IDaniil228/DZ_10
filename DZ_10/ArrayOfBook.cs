using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_10
{
    internal class ArrayOfBook
    {
        private List<Book> books = new List<Book>();
        public List<Book> Books
        {
            get { return books; }
        }
        /// <summary>
        /// Добавляет книгу в лист
        /// </summary>
        /// <param name="a"></param>
        public void AddToList(Book a)
        {
            books.Add(a);
        }
        /// <summary>
        /// ввыводит инфо о книгах
        /// </summary>
        public void ShowList()
        {
            foreach (Book a in books)
            {
                a.ShowBook();
            }
        }
        /// <summary>
        /// сортирует лист
        /// </summary>
        /// <param name="comparison"></param>
        public void Sort(Comparison<Book> comparison)
        {
            books.Sort(comparison);
        }
    }
}
