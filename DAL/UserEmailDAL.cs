using DAL.Data.DbContexts;
using DAL.EFModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UserEmailDAL
    {
        private readonly AssignmenttMVCContext _context;
        public UserEmailDAL(AssignmenttMVCContext context)
        {
            _context = context;
        }

        public string GetUserEmail(string userName)
        {
            string userEmail=null;
            foreach (var i in _context.Registers)
            {
                if (i.UserName == userName)
                {
                    userEmail = i.EmailId;
                    break;
                }
            }
            
            return userEmail;
        }
    }
}
