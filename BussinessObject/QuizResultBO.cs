using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObject
{
    public class QuizResultBO
    {
        public int id { get; set; }
        public int Score { get; set; }
        public int Lessonid { get; set; }
        public int Userid { get; set; }
        public DateTime date { get; set; }

    }
}
