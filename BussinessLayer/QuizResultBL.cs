using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObject;
using DataAccessLayer;

namespace BussinessLayer
{
    public class QuizResultBL
    {
        public bool SaveQuizResult(QuizResultBO resultBO)
        {
            DataAccess d = new DataAccess();
            return d.SaveQuizResult(resultBO);
        }
        public bool IsQuizPassed(int score,int numberQs)
        {
            if((score/numberQs)*100 > 50)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
