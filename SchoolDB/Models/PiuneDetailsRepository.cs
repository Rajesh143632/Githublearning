using SchoolDB.Contacts;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SchoolDB.Models
{
    public class PiuneDetailsRepository : IPiuneDetailsRepository
    {
        public List<PiuneDetails> GetAll()
        {
            PiuneDetails piune = null;
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-3LQJUUD;Initial Catalog=SchoolDB;User ID=sa;Password=123");
            string query = "Select * from dbo.PiuneDetails";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            List<PiuneDetails> piuneDetails = new List<PiuneDetails>();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                int Id = (int)dr[0];
                string PiuneName = dr[1].ToString();
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
                piuneDetails.Add(piune);
            }
            con.Close();
            return piuneDetails;
        }

        public PiuneDetails Get(int Id)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-3LQJUUD;Initial Catalog=SchoolDB;User ID=sa;Password=123");
            string query = "Select * from dbo.PiuneDetails Where Id = @Id";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Id", Id);
            con.Open();
            PiuneDetails piuneDetails = null;
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                piuneDetails = new PiuneDetails
                {
                    Id = (int)dr[0],
                    PiuneName = dr[1].ToString(),
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
                    CreatedBy = (int)dr[13],

                };
                con.Close();
            }
            return piuneDetails;
        }
        public bool Post(PiuneDetails piuneDetails)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-3LQJUUD;Initial Catalog=SchoolDB;User ID=sa;Password=123");
            string query = "Insert into dbo.PiuneDetails (PiuneName,SchoolId,Address,Salary,DepartmentId,Age,Gender,City,State,Country,IsActive,CreatedDateTime,ContactId,CreatedBy) Values(@PiuneName,@SchoolId,@Address,@Salary,@DepartmentId,@Age,@Gender,@City,@State,@Country,@IsActive,@CreatedDateTime,@ContactId,@CreatedBy)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@PiuneName", piuneDetails.PiuneName);
            cmd.Parameters.AddWithValue("@SchoolId", piuneDetails.SchoolId);
            cmd.Parameters.AddWithValue("@Address", piuneDetails.Address);
            cmd.Parameters.AddWithValue("@Salary", piuneDetails.Salary);
            cmd.Parameters.AddWithValue("@DepartmentId", piuneDetails.DepartmentId);
            cmd.Parameters.AddWithValue("@Age", piuneDetails.Age);
            cmd.Parameters.AddWithValue("@Gender", piuneDetails.Gender);
            cmd.Parameters.AddWithValue("@City", piuneDetails.City);
            cmd.Parameters.AddWithValue("@State", piuneDetails.State);
            cmd.Parameters.AddWithValue("@Country", piuneDetails.Country);
            cmd.Parameters.AddWithValue("@IsActive", piuneDetails.IsActive);
            cmd.Parameters.AddWithValue("@CreatedDateTime", piuneDetails.CreatedDateTime);
            cmd.Parameters.AddWithValue("@ContactId", piuneDetails.ContactId);
            cmd.Parameters.AddWithValue("@CreatedBy", piuneDetails.CreatedBy);
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
        public bool Put(PiuneDetails piuneDetails)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-3LQJUUD;Initial Catalog=SchoolDB;User ID=sa;Password=123");
            string query = ("Update dbo.PiuneDetails Set PiuneName=@PiuneName,SchoolId=@SchoolId,Address=@Address,Salary=@Salary,DepartmentId=@DepartmentId,Age=@Age,Gender=@Gender,City=@City,State=@State,Country=@Country,IsActive=@IsActive,CreatedDateTime=@CreatedDateTime,ContactId=@ContactId,CreatedBy=@CreatedBy Where Id = @Id");
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Id", piuneDetails.Id);
            cmd.Parameters.AddWithValue("@PiuneName", piuneDetails.PiuneName);
            cmd.Parameters.AddWithValue("@SchoolId", piuneDetails.SchoolId);
            cmd.Parameters.AddWithValue("@Address", piuneDetails.Address);
            cmd.Parameters.AddWithValue("@Salary", piuneDetails.Salary);
            cmd.Parameters.AddWithValue("@DepartmentId", piuneDetails.DepartmentId);
            cmd.Parameters.AddWithValue("@Age", piuneDetails.Age);
            cmd.Parameters.AddWithValue("@Gender", piuneDetails.Gender);
            cmd.Parameters.AddWithValue("@City", piuneDetails.City);
            cmd.Parameters.AddWithValue("@State", piuneDetails.State);
            cmd.Parameters.AddWithValue("@Country", piuneDetails.Country);
            cmd.Parameters.AddWithValue("@IsActive", piuneDetails.IsActive);
            cmd.Parameters.AddWithValue("@CreatedDateTime", piuneDetails.CreatedDateTime);
            cmd.Parameters.AddWithValue("@ContactId", piuneDetails.ContactId);
            cmd.Parameters.AddWithValue("@CreatedBy", piuneDetails.CreatedBy);
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
            string query = "Delete from dbo.PiuneDetails Where Id = @Id";
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
