using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
namespace Controllers
{
    public class MembersController
    {
        public static List<Member> getAllMembers(out String error)
        {
            return Member.getAllMembers(out error);
        }
        public static void addMemeber(Member m, out String error)
        {
            Member.AddMember(m, out error);
        }

        public static void UpdateMemeber(Member m, out string error)
        {
            Member.UpadateMembers(m, out error);
        }
    }
}
