using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
namespace BindingData
{
    public class BorrowBinding
    {
        private long id;
        private String refeenceBook;
        private String bookTitle;
        private String codeMember;
        private String memberFullName;
        private DateTime dateBringback;
        private DateTime dateBorrow;

        public BorrowBinding()
        {
        }

        public BorrowBinding(Borrow borrow)
        {
            this.Id = borrow.Id;
            this.RefeenceBook = borrow.Book.BookReference;
            this.BookTitle = borrow.Book.Booktitle;
            this.CodeMember = borrow.Member.Code;
            this.MemberFullName = borrow.Member.First_name + " "+ borrow.Member.Last_name;
            this.DateBringback = borrow.DateBorrow;
            this.DateBorrow = borrow.DateBringback;
        }
        public List<BorrowBinding> getBindedBorrows(List<Borrow> borrows)
        {
            List<BorrowBinding> listBorrows = new List<BorrowBinding>();
            foreach (var b in borrows)
            {
                listBorrows.Add(new BorrowBinding(b));
            }
            return listBorrows;
        }
        public Borrow getReverseBinding(List<Borrow> borrows)
        {
            return borrows.Find(b => b.Id == this.Id);
        }

        public long Id { get => id; set => id = value; }
        public string RefeenceBook { get => refeenceBook; set => refeenceBook = value; }
        public string BookTitle { get => bookTitle; set => bookTitle = value; }
        public string CodeMember { get => codeMember; set => codeMember = value; }
        public string MemberFullName { get => memberFullName; set => memberFullName = value; }
        public DateTime DateBringback { get => dateBringback; set => dateBringback = value; }
        public DateTime DateBorrow { get => dateBorrow; set => dateBorrow = value; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
