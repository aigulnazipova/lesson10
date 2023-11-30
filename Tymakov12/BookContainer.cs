using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tymakov12
{
    delegate int BookComparison(Book book);
    internal class BookContainer
    {
        private static List<Book> books = new List<Book>();

        public static List<Book> Books
        {
            get 
            { 
                return books; 
            }
            set 
            { 
                books = value; 
            }
        }
        public BookContainer(List<Book> books) 
        {
            Books = books;
        }
        public void Add(Book book) 
        {
            books.Add(book);
        }
        public static void SortBooks(Comparison<Book> comparison)
        {
            books.Sort(comparison);
        }
    }
}
