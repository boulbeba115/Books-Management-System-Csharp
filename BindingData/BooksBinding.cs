using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;

namespace BindingData
{
    public class BooksBinding
    {
        long id;
        String reference;
        String title;
        String author;
        int releaseYear;
        int nbPages;
        int nbChapter;
        String edition;
        String category;
        int currentQuantity;
        int totalQuantity;

        public BooksBinding(Book book)
        {
            this.Id = book.Id;
            this.Reference = book.BookReference;
            this.Title = book.Booktitle;
            this.Author = book.Author;
            this.ReleaseYear = book.ReleaseYear;
            this.NbPages = book.NbPages;
            this.NbChapter = book.NbChapter;
            this.Edition = "Edition"+ book.Edition;
            this.Category =book.Category.CategoryName;
            this.CurrentQuantity = book.CurrentQuantity;
            this.TotalQuantity = book.TotalQuantity;
        }
        public BooksBinding()
        {
            
        }
        public long Id { get => id; set => id = value; }
        public string Reference { get => reference; set => reference = value; }
        public string Title { get => title; set => title = value; }
        public string Author { get => author; set => author = value; }
        public int ReleaseYear { get => releaseYear; set => releaseYear = value; }
        public int NbPages { get => nbPages; set => nbPages = value; }
        public int NbChapter { get => nbChapter; set => nbChapter = value; }
        public string Edition { get => edition; set => edition = value; }
        public string Category { get => category; set => category = value; }
        public int CurrentQuantity { get => currentQuantity; set => currentQuantity = value; }
        public int TotalQuantity { get => totalQuantity; set => totalQuantity = value; }

        public static List<BooksBinding> bindbooks(List<Book> books)
        {
            List<BooksBinding> bindings = new List<BooksBinding>();
            foreach(Book b in books)
            {
                bindings.Add(new BooksBinding(b));
            }
            return bindings;
        }

        public Book reverseBind()
        {
            String error;
            Book book = new Book();
            book.Id = this.Id;
            book.BookReference = this.Reference;
            book.Booktitle = this.Title;
            book.Author = this.Author;
            book.ReleaseYear = this.ReleaseYear;
            book.NbPages = this.NbPages;
            book.NbChapter = this.NbChapter;
            book.Edition = Convert.ToInt32(new String(this.Edition.Where(Char.IsDigit).ToArray()));
            book.CurrentQuantity = this.CurrentQuantity;
            book.TotalQuantity = this.TotalQuantity;
            book.Category = Models.Category.getCategoryByName(this.Category,out error);
            return book;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
