using SchoolDB.Contacts;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SchoolDB.Models
{
    public class SecurityStaffDetailsRepository : ISecurityStaffDetailsRepository
    {
        public List<SecurityStaffDetails> GetAll()
        {
           
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-3LQJUUD;Initial Catalog=SchoolDB;User ID=sa;Password=123");
            string query = "Select * from dbo.SecurityStaffDetails";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            List<SecurityStaffDetails> securityStaffDetails = new List<SecurityStaffDetails>();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                SecurityStaffDetails staffDetails = new SecurityStaffDetails()
                {
                        Id = (int)dr[0],
                        SecurityName = dr[1].ToString(),
                       SchoolId = (int)dr[2],
                      Address = dr[3].ToString(),
                     Salary = (int)dr[4],
                    DepartmentId = (int)dr[5],
                        Age = (int)dr[6],
                    Gender = dr[7].ToString(),
                      City = dr[8].ToString(),
                       State = dr[9].ToString(),
                         Country = dr[10].ToString(),
                        IsActive = (bool)dr[11],
                   CreatedDateTime = (DateTime)dr[12],
                     ContactId = (int)dr[13],
               CreatedBy = (int)dr[14],
            };
                securityStaffDetails.Add(staffDetails);
            }
            con.Close();
            return securityStaffDetails;
        }

        public SecurityStaffDetails Get(int Id)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-3LQJUUD;Initial Catalog=SchoolDB;User ID=sa;Password=123");
            string query = "Select * from dbo.SecurityStaffDetails Where Id = @Id";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Id", Id);
            con.Open();
            SecurityStaffDetails staffDetails = null;
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                staffDetails = new SecurityStaffDetails
                {
                    Id = (int)dr[0],
                    SecurityName = dr[1].ToString(),
                    SchoolId = (int)dr[2],
                    Address = dr[3].ToString(),
                    Salary = (int)dr[4],
                    DepartmentId = (int)dr[5],
                    Age = (int)dr[6],
                    Gender = dr[7].ToString(),
                    City = dr[8].ToString(),
                    State = dr[9].ToString(),
                    Country = dr[10].ToString(),
                    IsActive = (bool)dr[11],
                    CreatedDateTime = (DateTime)dr[12],
                    ContactId = (int)dr[13],
                    CreatedBy = (int)dr[14],

                };
                con.Close();
            }
            return staffDetails;
        }
        public bool Post(SecurityStaffDetails securityStaffDetails)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-3LQJUUD;Initial Catalog=SchoolDB;User ID=sa;Password=123");
            string query = "Insert into dbo.SecurityStaffDetails (SecurityName,SchoolId,Address,Salary,DepartmentId,Age,Gender,City,State,Country,IsActive,CreatedDateTime,ContactId,CreatedBy) Values(@SecurityName,@SchoolId,@Address,@Salary,@DepartmentId,@Age,@Gender,@City,@State,@Country,@IsActive,@CreatedDateTime,@ContactId,@CreatedBy)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@SecurityName", securityStaffDetails.SecurityName);
            cmd.Parameters.AddWithValue("@SchoolId", securityStaffDetails.SchoolId);
            cmd.Parameters.AddWithValue("@Address", securityStaffDetails.Address);
            cmd.Parameters.AddWithValue("@Salary", securityStaffDetails.Salary);
            cmd.Parameters.AddWithValue("@DepartmentId", securityStaffDetails.DepartmentId);
            cmd.Parameters.AddWithValue("@Age", securityStaffDetails.Age);
            cmd.Parameters.AddWithValue("@Gender", securityStaffDetails.Gender);
            cmd.Parameters.AddWithValue("@City", securityStaffDetails.City);
            cmd.Parameters.AddWithValue("@State", securityStaffDetails.State);
            cmd.Parameters.AddWithValue("@Country", securityStaffDetails.Country);
            cmd.Parameters.AddWithValue("@IsActive", securityStaffDetails.IsActive);
            cmd.Parameters.AddWithValue("@CreatedDateTime", securityStaffDetails.CreatedDateTime);
            cmd.Parameters.AddWithValue("@ContactId", securityStaffDetails.ContactId);
            cmd.Parameters.AddWithValue("@CreatedBy", securityStaffDetails.CreatedBy);
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
        public bool Put(SecurityStaffDetails securityStaffDetails)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-3LQJUUD;Initial Catalog=SchoolDB;User ID=sa;Password=123");
            string query = ("Update dbo.PiuneDetails Set SecurityName=@SecurityName,SchoolId=@SchoolId,Address=@Address,Salary=@Salary,DepartmentId=@DepartmentId,Age=@Age,Gender=@Gender,City=@City,State=@State,Country=@Country,IsActive=@IsActive,CreatedDateTime=@CreatedDateTime,ContactId=@ContactId,CreatedBy=@CreatedBy Where Id = @Id");
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Id", securityStaffDetails.Id);
            cmd.Parameters.AddWithValue("@SecurityName", securityStaffDetails.SecurityName);
            cmd.Parameters.AddWithValue("@SchoolId", securityStaffDetails.SchoolId);
            cmd.Parameters.AddWithValue("@Address", securityStaffDetails.Address);
            cmd.Parameters.AddWithValue("@Salary", securityStaffDetails.Salary);
            cmd.Parameters.AddWithValue("@DepartmentId", securityStaffDetails.DepartmentId);
            cmd.Parameters.AddWithValue("@Age", securityStaffDetails.Age);
            cmd.Parameters.AddWithValue("@Gender", securityStaffDetails.Gender);
            cmd.Parameters.AddWithValue("@City", securityStaffDetails.City);
            cmd.Parameters.AddWithValue("@State", securityStaffDetails.State);
            cmd.Parameters.AddWithValue("@Country", securityStaffDetails.Country);
            cmd.Parameters.AddWithValue("@IsActive", securityStaffDetails.IsActive);
            cmd.Parameters.AddWithValue("@CreatedDateTime", securityStaffDetails.CreatedDateTime);
            cmd.Parameters.AddWithValue("@ContactId", securityStaffDetails.ContactId);
            cmd.Parameters.AddWithValue("@CreatedBy", securityStaffDetails.CreatedBy);
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
            string query = "Delete from dbo.SecurityStaffDetails Where Id = @Id";
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
