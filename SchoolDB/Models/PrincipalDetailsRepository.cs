using SchoolDB.Contacts;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SchoolDB.Models
{
    public class PrincipalDetailsRepository : IPrincipalDetailsRepository
    {
        public List<PrincipalDetails> GetAll()
        {
  
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-3LQJUUD;Initial Catalog=SchoolDB;User ID=sa;Password=123");
            string query = "Select * from dbo.PrincipalDetails";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            List<PrincipalDetails> principals = new List<PrincipalDetails>();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                PrincipalDetails principalDetails = new PrincipalDetails()
                {
                 Id = (int)dr[0],
                PrincipalName = dr[1].ToString(),
                   SchoolId = (int)dr[2],
                  Address = dr[3].ToString(),
                  Salary = (int)dr[4],
                  ContactId = (int)dr[5],
                     Age = (int)dr[6],
                      Gender = dr[7].ToString(),
                      City = dr[8].ToString(),
                      State = dr[9].ToString(),
                         Country = dr[10].ToString(),
                         IsActive = (bool)dr[11],
                     CreatedDateTime = (DateTime)dr[12],
                 CreatedBy = (int)dr[13],
            };
                principals.Add(principalDetails);
            }
            con.Close();
            return principals;
        }

        public PrincipalDetails Get(int Id)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-3LQJUUD;Initial Catalog=SchoolDB;User ID=sa;Password=123");
            string query = "Select * from dbo.PrincipalDetails Where Id = @Id";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Id", Id);
            con.Open();
            PrincipalDetails principal = null;
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                principal = new PrincipalDetails
                {
                    Id = (int)dr[0],
                    PrincipalName = dr[1].ToString(),
                    SchoolId = (int)dr[2],
                    Address = dr[3].ToString(),
                    Salary = (int)dr[4],
                    ContactId = (int)dr[5],
                    Age = (int)dr[6],
                    Gender = dr[7].ToString(),
                    City = dr[8].ToString(),
                    State = dr[9].ToString(),
                    Country = dr[10].ToString(),
                    IsActive = (bool)dr[11],
                    CreatedDateTime = (DateTime)dr[12],
                    CreatedBy = (int)dr[13],

                };
                con.Close();
            }
            return principal;
        }
        public bool Post(PrincipalDetails principalDetails)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-3LQJUUD;Initial Catalog=SchoolDB;User ID=sa;Password=123");
            string query = "Insert into dbo.principalDetails (PrincipalName,SchoolId,Address,Salary,ContactId,Age,Gender,City,State,Country,IsActive,CreatedDateTime,CreatedBy) Values(@PrincippalName,@SchoolId,@Address,@Salary,@DepartmentId,@Age,@Gender,@City,@State,@Country,@IsActive,@CreatedDateTime,@CreatedBy)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@PrincipalName", principalDetails.PrincipalName);
            cmd.Parameters.AddWithValue("@SchoolId", principalDetails.SchoolId);
            cmd.Parameters.AddWithValue("@Address", principalDetails.Address);
            cmd.Parameters.AddWithValue("@Salary", principalDetails.Salary);
            cmd.Parameters.AddWithValue("@ContactId", principalDetails.ContactId);
            cmd.Parameters.AddWithValue("@Age", principalDetails.Age);
            cmd.Parameters.AddWithValue("@Gender", principalDetails.Gender);
            cmd.Parameters.AddWithValue("@City", principalDetails.City);
            cmd.Parameters.AddWithValue("@State", principalDetails.State);
            cmd.Parameters.AddWithValue("@Country", principalDetails.Country);
            cmd.Parameters.AddWithValue("@IsActive", principalDetails.IsActive);
            cmd.Parameters.AddWithValue("@CreatedDateTime", principalDetails.CreatedDateTime);
            cmd.Parameters.AddWithValue("@CreatedBy", principalDetails.CreatedBy);
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
        public bool Put(PrincipalDetails principalDetails)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-3LQJUUD;Initial Catalog=SchoolDB;User ID=sa;Password=123");
            string query = ("Update dbo.PrincipalDetails Set PrincipalName=@PrincipalName,SchoolId=@SchoolId,Address=@Address,Salary=@Salary,ContactId=@ContactId,Age=@Age,Gender=@Gender,City=@City,State=@State,Country=@Country,IsActive=@IsActive,CreatedDateTime=@CreatedDateTime,CreatedBy=@CreatedBy Where Id = @Id");
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Id", principalDetails.Id);
            cmd.Parameters.AddWithValue("@PrincipalName", principalDetails.PrincipalName);
            cmd.Parameters.AddWithValue("@SchoolId", principalDetails.SchoolId);
            cmd.Parameters.AddWithValue("@Address", principalDetails.Address);
            cmd.Parameters.AddWithValue("@Salary", principalDetails.Salary);
            cmd.Parameters.AddWithValue("@ContactId", principalDetails.ContactId);
            cmd.Parameters.AddWithValue("@Age", principalDetails.Age);
            cmd.Parameters.AddWithValue("@Gender", principalDetails.Gender);
            cmd.Parameters.AddWithValue("@City", principalDetails.City);
            cmd.Parameters.AddWithValue("@State", principalDetails.State);
            cmd.Parameters.AddWithValue("@Country", principalDetails.Country);
            cmd.Parameters.AddWithValue("@IsActive", principalDetails.IsActive);
            cmd.Parameters.AddWithValue("@CreatedDateTime", principalDetails.CreatedDateTime);
            cmd.Parameters.AddWithValue("@CreatedBy", principalDetails.CreatedBy);
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
            string query = "Delete from dbo.PrincipalDetails Where Id = @Id";
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


