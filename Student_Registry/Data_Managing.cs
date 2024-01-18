using Microsoft.Data.SqlClient;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing.Text;

namespace Student_Registry
{
    public class Management
    {
        public Teacher BuildTeacherModel(string email, string password)
        {
            string name = email.Split('.', '@')[0] + " " + email.Split('.', '@')[1];
            Teacher teacher = new Teacher{ Email = email, Password = password, Name = name};
            return teacher;
        }

        public readonly string conString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\Proiecte C#\\Proiecte\\Student_Registry\\Student_Registry\\School.mdf\";Integrated Security=True";

        public void LoadData()
        {
            ClearDB();
            using(SqlConnection con = new SqlConnection(conString))
            {
                con.Open();

                string cmdTeachers = "Insert into Teachers (Email, Password, Classes) values (@email, @password, @classes)";
                string cmdClasses = "Insert into Classes (Name, Students) values (@name, @students)";
                string cmdStudents = "Insert into Grades (Name, Grades) values (@name, @grades)";

                string filePathTeachers = "Teachers.txt";
                string filePathClasses = "Classes.txt";
                string filePathStudents = "Student_Grades.txt";

                using (StreamReader reader = new StreamReader(filePathTeachers))
                {
                    while(reader.Peek() >= 0)
                    {
                        var line = reader.ReadLine().Split("*");
                        using(SqlCommand cmd = new SqlCommand(cmdTeachers, con))
                        {
                            cmd.Parameters.AddWithValue("Email", line[0]);
                            cmd.Parameters.AddWithValue("Password", line[1]);
                            cmd.Parameters.AddWithValue("Classes", line[2]);

                            cmd.ExecuteNonQuery();
                        }
                    }
                }

                using (StreamReader reader = new StreamReader(filePathClasses))
                {
                    while (reader.Peek() >= 0)
                    {
                        var line = reader.ReadLine().Split("*");
                        using (SqlCommand cmd = new SqlCommand(cmdClasses, con))
                        {
                            cmd.Parameters.AddWithValue("Name", line[0]);
                            cmd.Parameters.AddWithValue("Students", line[1]);

                            cmd.ExecuteNonQuery();
                        }
                    }
                }

                using (StreamReader reader = new StreamReader(filePathStudents))
                {
                    while (reader.Peek() >= 0)
                    {
                        var line = reader.ReadLine().Split("*");
                        using (SqlCommand cmd = new SqlCommand(cmdStudents, con))
                        {
                            cmd.Parameters.AddWithValue("Name", line[0]);
                            cmd.Parameters.AddWithValue("Grades", line[1]);

                            cmd.ExecuteNonQuery();
                        }
                    }
                }
            }

            
        }

        public Teacher CheckTeacher(string username)
        {
            Teacher teachershell = new Teacher();
            using(SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                string cmdsearchTeacher = "Select Email, Password from Teachers where Email = @email";

                using(SqlCommand cmd = new SqlCommand( cmdsearchTeacher, con))
                {
                    cmd.Parameters.AddWithValue ("Email", username);
                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            teachershell.Name = (string)reader["Email"];
                            teachershell.Password = (string)reader["Password"];

                            
                        }
                        
                            
                    }
                }
            }

            return teachershell;
        }
        private void ClearDB() 
        {
            using(SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                string cmdText = "Delete from Teachers";
                EndQuery(con, cmdText);
                cmdText = "Delete from Classes";
                EndQuery(con, cmdText);
                cmdText = "Delete from Grades";
                EndQuery(con, cmdText);
            }
        }

        private void EndQuery(SqlConnection con, string cmdText)
        {
            using (SqlCommand cmd = new SqlCommand(cmdText, con))
            {
                cmd.ExecuteNonQuery();
            }
        }
    }
}