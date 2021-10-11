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
        DataAccess d = new DataAccess();
        public int addUser(UserBO userBO)
        {
            
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
                    return 1; 
                }
                else
                {
                    return 2;
                }
            }
        }

        public int getUserID(string email)
        {
            return d.getUserID(email);
        }
        public UserBO getUser(string email, string password)
        {
            return d.GetUSer(email, password);
        }

    }
}
