using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using BindingData;

namespace Controllers
{
    public class BooksController
    {
        //show All books
        public static List<BooksBinding> getAllBooks(out String error)
        {
            List<Book> books = Book.getAllBooks(out error);
            return BooksBinding.bindbooks(books);
        }
        public static void UpdateBook(Book b , out String error)
        {
            Book.updateBook(b,out error);
        }
        public static void addBook(Book b, out String error)
        {
            Book.AddBook(b, out error);
        }
        public static void bookOut(Book b, out String error)
        {
            Book.bookOut(b, out error);
        }
        public static void bookIn(Book b, out String error)
        {
            Book.bookIn(b, out error);
        }
    }
}
