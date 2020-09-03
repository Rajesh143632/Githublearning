using SchoolDB.Contacts;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SchoolDB.Models
{
    public class TeacherDetailsRepository : ITeacherDetailsRepository
    {
        public List<TeacherDetails> GetAll()
        {
            TeacherDetails teacherDetails = null;
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-3LQJUUD;Initial Catalog=SchoolDB;User ID=sa;Password=123");
            string query = "Select * from dbo.TeacherDetails";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            List<TeacherDetails> teachers = new List<TeacherDetails>();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                int Id = (int)dr[0];
                string TeacherName = dr[1].ToString();
                int SchoolId = (int)dr[2];
                string Address = dr[3].ToString();
                int Salary = (int)dr[4];
                int DepartmentId = (int)dr[5];
                int Age = (int)dr[6];
                string Gender = dr[7].ToString();
                string City = dr[8].ToString();
                string State = dr[9].ToString();
                string Country = dr[10].ToString();
                DateTime CreatedDateTime = (DateTime)dr[11];
                int ContactId = (int)dr[12];
                int CreatedBy = (int)dr[13];
                teachers.Add(teacherDetails);
            }
            con.Close();
            return teachers;
        }

        public TeacherDetails Get(int Id)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-3LQJUUD;Initial Catalog=SchoolDB;User ID=sa;Password=123");
            string query = "Select * from dbo.TeacherDetails Where Id = @Id";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Id", Id);
            con.Open();
            TeacherDetails teacherDetails = null;
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                teacherDetails = new TeacherDetails
                {
                    Id = (int)dr[0],
                    TeacherName = dr[1].ToString(),
                    SchoolId = (int)dr[2],
                    Address = dr[3].ToString(),
                    Salary = (int)dr[4],
                    DepartmentId = (int)dr[5],
                    Age = (int)dr[6],
                    Gender = dr[7].ToString(),
                    City = dr[8].ToString(),
                    State = dr[9].ToString(),
                    Country = dr[10].ToString(),
                    CreatedDateTime = (DateTime)dr[11],
                    ContactId = (int)dr[12],
                    CreatedBy = (int)dr[13]

                };
                con.Close();
            }
            return teacherDetails;
        }
        public bool Post(TeacherDetails teacherDetails)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-3LQJUUD;Initial Catalog=SchoolDB;User ID=sa;Password=123");
            string query = "Insert into dbo.TeacherDetails (TeacherName,SchoolId,Address,Salary,DepartmentId,Age,Gender,City,State,Country,IsActive,CreatedDateTime,ContactId,CreatedBy) Values(@TeacherName,@SchoolId,@Address,@Salary,@DepartmentId,@Age,@Gender,@City,@State,@Country,@IsActive,@CreatedDateTime,@ContactId,@CreatedBy)";
            SqlCommand cmd = new SqlCommand(query, con);
            
            cmd.Parameters.AddWithValue("@TeacherName", teacherDetails.TeacherName);
            cmd.Parameters.AddWithValue("@SchoolId", teacherDetails.SchoolId);
            cmd.Parameters.AddWithValue("@Address", teacherDetails.Address);
            cmd.Parameters.AddWithValue("@Salary", teacherDetails.Salary);
            cmd.Parameters.AddWithValue("@DepartmentId", teacherDetails.DepartmentId);
            cmd.Parameters.AddWithValue("@Age", teacherDetails.Age);
            cmd.Parameters.AddWithValue("@Gender", teacherDetails.Gender);
            cmd.Parameters.AddWithValue("@City", teacherDetails.City);
            cmd.Parameters.AddWithValue("@State", teacherDetails.State);
            cmd.Parameters.AddWithValue("@Country", teacherDetails.Country);
            cmd.Parameters.AddWithValue("@IsActive", teacherDetails.IsActive);
            cmd.Parameters.AddWithValue("@CreatedDateTime", teacherDetails.CreatedDateTime);
            cmd.Parameters.AddWithValue("@ContactId", teacherDetails.ContactId);
            cmd.Parameters.AddWithValue("@CreatedBy", teacherDetails.CreatedBy);
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
        public bool Put(TeacherDetails teacherDetails)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-3LQJUUD;Initial Catalog=SchoolDB;User ID=sa;Password=123");
            string query = ("Update dbo.SecurityStaffDetails Set TeacherName=@TeacherName,SchoolId=@SchoolId,Address=@Address,Salary=@Salary,DepartmentId=@DepartmentId,Age=@Age,Gender=@Gender,City=@City,State=@State,Country=@Country,IsActive=@IsActive,CreatedDateTime=@CreatedDateTime,ContactId=@ContactId,CreatedBy=@CreatedBy Where Id = @Id");
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Id", teacherDetails.Id);
            cmd.Parameters.AddWithValue("@TeacherName", teacherDetails.TeacherName);
            cmd.Parameters.AddWithValue("@SchoolId", teacherDetails.SchoolId);
            cmd.Parameters.AddWithValue("@Address", teacherDetails.Address);
            cmd.Parameters.AddWithValue("@Salary", teacherDetails.Salary);
            cmd.Parameters.AddWithValue("@DepartmentId", teacherDetails.DepartmentId);
            cmd.Parameters.AddWithValue("@Age", teacherDetails.Age);
            cmd.Parameters.AddWithValue("@Gender", teacherDetails.Gender);
            cmd.Parameters.AddWithValue("@City", teacherDetails.City);
            cmd.Parameters.AddWithValue("@State", teacherDetails.State);
            cmd.Parameters.AddWithValue("@Country", teacherDetails.Country);
            cmd.Parameters.AddWithValue("@IsActive", teacherDetails.IsActive);
            cmd.Parameters.AddWithValue("@CreatedDateTime", teacherDetails.CreatedDateTime);
            cmd.Parameters.AddWithValue("@ContactId", teacherDetails.ContactId);
            cmd.Parameters.AddWithValue("@CreatedBy", teacherDetails.CreatedBy);
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
            string query = "Delete from dbo.TeacherDetails Where Id = @Id";
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


