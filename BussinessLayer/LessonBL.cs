using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObject;
using DataAccessLayer;
namespace BussinessLayer
{
    public class LessonBL
    {
        public LessonBO getLesson(int id)
        {
            DataAccess d = new DataAccess();
            LessonBO lesson = new LessonBO();
            lesson = d.getLesson(id);
            return lesson;
        }
    }
}
