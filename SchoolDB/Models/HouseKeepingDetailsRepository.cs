using SchoolDB.Contacts;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SchoolDB.Models
{
    public class HouseKeepingDetailsRepository : IHouseKeepingDetailsRepository
    {
        public List<HouseKeepingDetails> GetAll()
        {
           
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-3LQJUUD;Initial Catalog=SchoolDB;User ID=sa;Password=123");
            string query = "Select * from dbo.HouseKeepingDetails";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            List<HouseKeepingDetails> houseKeepings = new List<HouseKeepingDetails>();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                HouseKeepingDetails house = new HouseKeepingDetails()
                {
                    Id = (int)dr[0],
                    HouseKeeperName = dr[1].ToString(),
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
                houseKeepings.Add(house);
            }
            con.Close();
            return houseKeepings;
        }

        public HouseKeepingDetails Get(int Id)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-3LQJUUD;Initial Catalog=SchoolDB;User ID=sa;Password=123");
            string query = "Select * from dbo.HouseKeeppingDetails Where Id = @Id";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Id", Id);
            con.Open();
            HouseKeepingDetails houseKeepingDetails = null;
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                houseKeepingDetails = new HouseKeepingDetails
                {
                   Id = (int)dr[0],
                   HouseKeeperName = dr[1].ToString(),
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
            return houseKeepingDetails;
        }
        public bool Post(HouseKeepingDetails houseKeepingDetails)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-3LQJUUD;Initial Catalog=SchoolDB;User ID=sa;Password=123");
            string query = "Insert into dbo.HouseKeepingDetails (HouseKeeperName,SchoolId,Address,Salary,DepartmentId,Age,Gender,City,State,Country,IsActive,CreatedDateTime,ContactId,CreatedBy) Values(@HouseKeeperName,@SchoolId,@Address,@Salary,@DepartmentId,@Age,@Gender,@City,@State,@Country,@IsActive,@CreatedDateTime,@ContactId,@CreatedBy)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@HouseKeeperName", houseKeepingDetails.HouseKeeperName);
            cmd.Parameters.AddWithValue("@SchoolId", houseKeepingDetails.SchoolId);
            cmd.Parameters.AddWithValue("@Address", houseKeepingDetails.Address);
            cmd.Parameters.AddWithValue("@Salary", houseKeepingDetails.Salary);
            cmd.Parameters.AddWithValue("@DepartmentId", houseKeepingDetails.DepartmentId);
            cmd.Parameters.AddWithValue("@Age", houseKeepingDetails.Age);
            cmd.Parameters.AddWithValue("@Gender", houseKeepingDetails.Gender);
            cmd.Parameters.AddWithValue("@City", houseKeepingDetails.City);
            cmd.Parameters.AddWithValue("@State", houseKeepingDetails.State);
            cmd.Parameters.AddWithValue("@Country", houseKeepingDetails.Country);
            cmd.Parameters.AddWithValue("@IsActive", houseKeepingDetails.IsActive);
            cmd.Parameters.AddWithValue("@CreatedDateTime", houseKeepingDetails.CreatedDateTime);
            cmd.Parameters.AddWithValue("@ContactId", houseKeepingDetails.ContactId);
            cmd.Parameters.AddWithValue("@CreatedBy", houseKeepingDetails.CreatedBy);
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
        public bool Put(HouseKeepingDetails houseKeepingDetails)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-3LQJUUD;Initial Catalog=SchoolDB;User ID=sa;Password=123");
            string query = ("Update dbo.HouseKeepingDetails Set HouseKeeperName=@HouseKeeperName,SchoolId=@SchoolId,Address=@Address,Salary=@Salary,DepartmentId=@DepartmentId,Age=@Age,Gender=@Gender,City=@City,State=@State,Country=@Country,IsActive=@IsActive,CreatedDateTime=@CreatedDateTime,ContactId=@ContactId,CreatedBy=@CreatedBy Where Id = @Id");
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Id", houseKeepingDetails.Id);
            cmd.Parameters.AddWithValue("@HouseKeeperName", houseKeepingDetails.HouseKeeperName);
            cmd.Parameters.AddWithValue("@SchoolId", houseKeepingDetails.SchoolId);
            cmd.Parameters.AddWithValue("@Address", houseKeepingDetails.Address);
            cmd.Parameters.AddWithValue("@Salary", houseKeepingDetails.Salary);
            cmd.Parameters.AddWithValue("@DepartmentId", houseKeepingDetails.DepartmentId);
            cmd.Parameters.AddWithValue("@Age", houseKeepingDetails.Age);
            cmd.Parameters.AddWithValue("@Gender", houseKeepingDetails.Gender);
            cmd.Parameters.AddWithValue("@City", houseKeepingDetails.City);
            cmd.Parameters.AddWithValue("@State", houseKeepingDetails.State);
            cmd.Parameters.AddWithValue("@Country", houseKeepingDetails.Country);
            cmd.Parameters.AddWithValue("@IsActive", houseKeepingDetails.IsActive);
            cmd.Parameters.AddWithValue("@CreatedDateTime", houseKeepingDetails.CreatedDateTime);
            cmd.Parameters.AddWithValue("@ContactId", houseKeepingDetails.ContactId);
            cmd.Parameters.AddWithValue("@CreatedBy", houseKeepingDetails.CreatedBy);
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
            string query = "Delete from dbo.HouseKeepingDetails Where Id = @Id";
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
