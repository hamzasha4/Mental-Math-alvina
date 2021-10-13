using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using BussinessObject;

namespace DataAccessLayer
{
    public class DataAccess
    {
        string strcon = ConfigurationManager.ConnectionStrings["Appdb"].ConnectionString;

        public bool checkMemberExists(UserBO userBO)
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("SELECT * from Users where email='" + userBO.email + "';", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count >= 1)
                {

                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool signUpNewMember(UserBO userBO)
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand(@"INSERT INTO Users(UserName,email,password,Account_status,Age,Progress,Role) 
                values(@UserName,@email,@password,@Account_status,@age,@progress,@role)", con);
                cmd.Parameters.AddWithValue("@UserName", userBO.UserName);
                cmd.Parameters.AddWithValue("@email", userBO.email);
                cmd.Parameters.AddWithValue("@password", userBO.password);
                cmd.Parameters.AddWithValue("@Account_status", userBO.status);
                cmd.Parameters.AddWithValue("@age", userBO.age);
                cmd.Parameters.AddWithValue("@progress", userBO.progress);
                cmd.Parameters.AddWithValue("@role", userBO.role);
                cmd.ExecuteNonQuery();
                con.Close();
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool inserttoQuizResultChild(List<QuizResultChildBO> quizResults)
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                foreach (var quizresult in quizResults)
                {
                    SqlCommand cmd = new SqlCommand(@"INSERT INTO QuizzResultChild(QuizResultid,Question,Result) 
                values(@QuizResultid, @Question,@Result)", con);
                    cmd.Parameters.AddWithValue("@QuizResultid", quizresult.QuizResultid);
                    cmd.Parameters.AddWithValue("@Question", quizresult.question_no);
                    cmd.Parameters.AddWithValue("@Result", quizresult.result);
                    cmd.ExecuteNonQuery();
                }
                con.Close();
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public UserBO GetUSer(string email, string password)
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("SELECT * from Users where email='" + email + "' AND password='" + password + "'", con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    UserBO user = new UserBO();
                    while (dr.Read())
                    {
                        user.Userid = Convert.ToInt32(dr.GetValue(0));
                        user.UserName = dr.GetValue(1).ToString();
                        user.status = dr.GetValue(4).ToString();
                        user.progress = Convert.ToInt32(dr.GetValue(6).ToString());
                        user.role = dr.GetValue(8).ToString();
                    }
                    con.Close();
                    return user;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
 
        public int getQuizResultid(int id,DateTime date)
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("SELECT * from QuizResult where Userid='" + id + "' and Date>='" + date + "';", con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    int QuizResultid = 0;
                    while (dr.Read())
                    {
                        QuizResultid = Convert.ToInt32(dr.GetValue(0));
                    }
                    con.Close();
                    return QuizResultid;
                }

                return 0;
            }
            catch
            {
                return -1;
            }
        }
        public int getUserID(string useremail)
        {
            try {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("SELECT * from Users where email='" + useremail + "';", con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    int id = 0;
                    while (dr.Read())
                    {
                        id = Convert.ToInt32(dr.GetValue(0));
                    }
                    con.Close();
                    return id;
                }

                return 0;
            }
            catch
            {
                return -1;
            }
            }

        public LessonBO getLesson(int id)
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("SELECT * from LESSONS where Lessonid='" + id + "';", con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    LessonBO lesson = new LessonBO();
                    while (dr.Read())
                    {
                        lesson.id= Convert.ToInt32(dr.GetValue(0));
                        lesson.video= dr.GetValue(1).ToString();
                    }
                    con.Close();
                    return lesson;
                }
                else {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }

        }

        public List<QuizQuestionsBO> GetQuizQuestions(int Lessonid)
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("SELECT * from QuizQuestions where Lessonid='" + Lessonid + "';", con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    List<QuizQuestionsBO> quizQuestionsBOs = new List<QuizQuestionsBO>();
                    while (dr.Read())
                    {
                        QuizQuestionsBO questionsBO = new QuizQuestionsBO();
                        questionsBO.id = Convert.ToInt32(dr.GetValue(0));
                        questionsBO.question = dr.GetValue(1).ToString();
                        questionsBO.ans = dr.GetValue(2).ToString();
                        quizQuestionsBOs.Add(questionsBO);
                    }
                    con.Close();
                    return quizQuestionsBOs;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {

                return null;
            }
        }

        public bool SaveQuizResult(QuizResultBO resultBO)
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd1 = new SqlCommand(@"insert into QuizResult(Score,Date,Userid,Lessonid)
                values(@score,@date,@userid,@lessonid)", con);
                cmd1.Parameters.AddWithValue("@score", resultBO.Score);
                cmd1.Parameters.AddWithValue("@date", resultBO.date);
                cmd1.Parameters.AddWithValue("@userid", resultBO.Userid);
                cmd1.Parameters.AddWithValue("@lessonid", resultBO.Lessonid);
                cmd1.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
    
