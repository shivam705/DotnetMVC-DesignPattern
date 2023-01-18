using DAL;
using DAL.EFModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
   public  class UserEmailBL
    {

        private readonly UserEmailDAL _useremailDal;

        

        public UserEmailBL(UserEmailDAL useremailDAL)
        {
            _useremailDal = useremailDAL;
        }

        public string GetUserEmail(string userName)
        {

            return _useremailDal.GetUserEmail(userName);

        }
    }
}
