using SchoolDB.Contacts;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SchoolDB.Models
{
    public class StudentDetailsRepository : IStudentDetailsRepository
    {
        public List<StudentDetails> GetAll()
        {
         
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-3LQJUUD;Initial Catalog=SchoolDB;User ID=sa;Password=123");
            string query = "Select * from dbo.SecurityStaffDetails";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            List<StudentDetails> students = new List<StudentDetails>();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                StudentDetails studentDetails = new StudentDetails()
                {
                     Id = (int)dr[0],
                    StudentName = dr[1].ToString(),
                       SchoolId = (int)dr[2],
                   Address = dr[3].ToString(),
                    Class = (int)dr[4],
                    CreatedBy = (int)dr[5],
                        Age = (int)dr[6],
                      Gender = dr[7].ToString(),
                       City = dr[8].ToString(),
                         State = dr[9].ToString(),
                         Country = dr[10].ToString(),
                          IsActive = (bool)dr[11],
                       CreatedDateTime = (DateTime)dr[12],
                   GurdianName = dr[13].ToString(),
                   ContactId = (int)dr[14],
                GurdianNumber = (int)dr[15],
            };
               
                students.Add(studentDetails);
            }
            con.Close();
            return students;
        }

        public StudentDetails Get(int Id)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-3LQJUUD;Initial Catalog=SchoolDB;User ID=sa;Password=123");
            string query = "Select * from dbo.StudentDetails Where Id = @Id";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Id", Id);
            con.Open();
            StudentDetails studentDetails = null;
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                studentDetails = new StudentDetails
                {
                   Id = (int)dr[0],
                    StudentName = dr[1].ToString(),
                    SchoolId = (int)dr[2],
                    Address = dr[3].ToString(),
                     Class = (int)dr[4],
                     CreatedBy = (int)dr[5],
                     Age = (int)dr[6],
                      Gender = dr[7].ToString(),
                     City = dr[8].ToString(),
                      State = dr[9].ToString(),
                      Country = dr[10].ToString(),
                      IsActive = (bool)dr[11],
                      CreatedDateTime = (DateTime)dr[12],
                       GurdianName = dr[13].ToString(),
                      ContactId = (int)dr[14],
                  GurdianNumber = (int)dr[15]
            };
                con.Close();
            }
            return studentDetails;
        }
        public bool Post(StudentDetails studentDetails)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-3LQJUUD;Initial Catalog=SchoolDB;User ID=sa;Password=123");
            string query = "Insert into dbo.StudentDetails (StudentName,SchoolId,Address,Class,CreatedBy,Age,Gender,City,State,Country,IsActive,CreatedDateTime,GurdianName,ContactId,GurdianNumber) Values(@StudentName,@SchoolId,@Address,@Class,@CreatedBy,@Age,@Gender,@City,@State,@Country,@IsActive,@CreatedDateTime,@GurdianName,@ContactId,@GurdianNumber)";
            SqlCommand cmd = new SqlCommand(query, con);
        
            cmd.Parameters.AddWithValue("@StudentNameName", studentDetails.StudentName);
            cmd.Parameters.AddWithValue("@SchoolId", studentDetails.SchoolId);
            cmd.Parameters.AddWithValue("@Address", studentDetails.Address);
            cmd.Parameters.AddWithValue("@Class", studentDetails.Class);
            cmd.Parameters.AddWithValue("@CreatedBy", studentDetails.CreatedBy);
            cmd.Parameters.AddWithValue("@Age", studentDetails.Age);
            cmd.Parameters.AddWithValue("@Gender", studentDetails.Gender);
            cmd.Parameters.AddWithValue("@City", studentDetails.City);
            cmd.Parameters.AddWithValue("@State", studentDetails.State);
            cmd.Parameters.AddWithValue("@Country", studentDetails.Country);
            cmd.Parameters.AddWithValue("@IsActive", studentDetails.IsActive);
            cmd.Parameters.AddWithValue("@CreatedDateTime", studentDetails.CreatedDateTime);
            cmd.Parameters.AddWithValue("@GurdianName", studentDetails.GurdianName);
            cmd.Parameters.AddWithValue("@ContactId", studentDetails.ContactId);
            cmd.Parameters.AddWithValue("@GurdianNumber", studentDetails.GurdianNumber);

            con.Open();
            int noOfRowAffected = cmd.ExecuteNonQuery();
            con.Close();
            if (noOfRowAffected > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Put(StudentDetails studentDetails)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-3LQJUUD;Initial Catalog=SchoolDB;User ID=sa;Password=123");
            string query = ("Update into dbo.StudentDetails Set StudentName=@StudentName,SchoolId=@SchoolId,Address=@Address,Class=@Class,CreatedBy=@CreatedBy,Age=@Age,Gender=@Gender,City=@City,State=@State,Country=@Country,IsActive=@IsActive,CreatedDateTime=@CreatedDateTime,GurdianName=@GurdianNameContactId=@ContactId,GurdianNumber=@GurdianNumber Where Id = @Id");
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Id", studentDetails.Id);
            cmd.Parameters.AddWithValue("@StudentNameName", studentDetails.StudentName);
            cmd.Parameters.AddWithValue("@SchoolId", studentDetails.SchoolId);
            cmd.Parameters.AddWithValue("@Address", studentDetails.Address);
            cmd.Parameters.AddWithValue("@Class", studentDetails.Class);
            cmd.Parameters.AddWithValue("@CreatedBy", studentDetails.CreatedBy);
            cmd.Parameters.AddWithValue("@Age", studentDetails.Age);
            cmd.Parameters.AddWithValue("@Gender", studentDetails.Gender);
            cmd.Parameters.AddWithValue("@City", studentDetails.City);
            cmd.Parameters.AddWithValue("@State", studentDetails.State);
            cmd.Parameters.AddWithValue("@Country", studentDetails.Country);
            cmd.Parameters.AddWithValue("@IsActive", studentDetails.IsActive);
            cmd.Parameters.AddWithValue("@CreatedDateTime", studentDetails.CreatedDateTime);
            cmd.Parameters.AddWithValue("@GurdianName", studentDetails.GurdianName);
            cmd.Parameters.AddWithValue("@ContactId", studentDetails.ContactId);
            cmd.Parameters.AddWithValue("@GurdianNumber", studentDetails.GurdianNumber);

            con.Open();
            int noOfRowAffected = cmd.ExecuteNonQuery();
            con.Close();
            if (noOfRowAffected > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Delete(int Id)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-3LQJUUD;Initial Catalog=SchoolDB;User ID=sa;Password=123");
            string query = "Delete from dbo.StudentDetails Where Id = @Id";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Id", Id);
            con.Open();
            int noOfRowAffected = cmd.ExecuteNonQuery();
            con.Close();
            if (noOfRowAffected > 0)
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
    