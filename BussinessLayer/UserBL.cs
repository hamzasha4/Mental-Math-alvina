using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObject;
using DataAccessLayer;

namespace BussinessLayer
{
    public class UserBL
    {
        public int addUser(UserBO userBO)
        {
            DataAccess d = new DataAccess();
            bool memberExist = d.checkMemberExists(userBO);
            if (memberExist)
            {
                return 0;
            }
            else
            {
                bool isSuccessfull = d.signUpNewMember(userBO);
                if (isSuccessfull)
                {
                    int id = d.getUserID(userBO.email);
                    return id; 

                }
                else
                {
                    return 0;
                }
            }
        }
        
    }
}
