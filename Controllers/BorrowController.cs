using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Controllers
{
    public class BorrowController
    {
        public static List<Borrow> getAllBorrows(out String error)
        {
            return Borrow.getAllBorrows(out error);
        }
        public static void addBorrow(Borrow b, out String error)
        {
            Borrow.AddBorrow(b, out error);
        }

        public static void UpadateBorrowing(Borrow b, out string error)
        {
            Borrow.UpadateBorrowing(b, out error);
        }
    }
}
