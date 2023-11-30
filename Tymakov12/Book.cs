using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tymakov12
{
    internal class Book
    {
        private string title;
        private string author;
        private string publishingHouse;

        public string Title 
        { 
            get 
            { 
                return title; 
            }  
        }
        public string Author
        { 
            get 
            { 
                return author; 
            } 
        }
        public string PublishingHouse
        {
            get
            {
                return publishingHouse;
            }
        }
        public Book(string title, string author, string publishingHouse)
        {
            this.title = title;
            this.author = author;
            this.publishingHouse = publishingHouse;
        }
        public override string ToString()
        {
            return $"{title}, {author}, {publishingHouse}";
        }
    }
}
