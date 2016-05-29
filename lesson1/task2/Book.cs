using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Book
    {
        //поля
        string bookname;
        string author;
        string content;

        //конструктор
        public Book (string bookname, string author, string content)
        {
            this.bookname = bookname;
            this.author = author;
            this.content = content;
        }

        //метод
        public void Show()
        {
            Author oAuthor = new Author();
            oAuthor.Data = author;

            Content oContent = new Content();
            oContent.Data = content;

            Console.WriteLine(bookname);
            oAuthor.Show();
            oContent.Show();
        }
    }
}
