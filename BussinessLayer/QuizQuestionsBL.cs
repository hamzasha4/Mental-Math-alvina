using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using BussinessObject;

namespace BussinessLayer
{
    public class QuizQuestionsBL
    {
        public List<QuizQuestionsBO> GetQuizQuestions(int Lessonid)
        {
            DataAccess d = new DataAccess();
            return d.GetQuizQuestions(Lessonid);
        }
    }
}
