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
        public int SaveQuizResult(QuizResultBO resultBO, List<QuizScoreBO> Scores)
        {
            DataAccess d = new DataAccess();
            if (d.SaveQuizResult(resultBO))
            {
                int quizid = d.getQuizResultid(resultBO.Userid, resultBO.date);
                List<QuizResultChildBO> quizResultChildren = new List<QuizResultChildBO>();
                if(quizid > 0)
                {
                    foreach (var r in Scores)
                    {
                        QuizResultChildBO childBO = new QuizResultChildBO();
                        childBO.QuizResultid = quizid;
                        childBO.question_no = Convert.ToInt32(r.id);
                        if (r.result == "true")
                        {
                            childBO.result = 1;
                        }
                        else
                        {
                            childBO.result = 0;
                        }
                        quizResultChildren.Add(childBO);
                    }
                if(d.inserttoQuizResultChild(quizResultChildren))
                    { return 1;}
                }
            }
            return 0;
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
