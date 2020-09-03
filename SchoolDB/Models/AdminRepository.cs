using SchoolDB.Contacts;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SchoolDB.Models
{
    public class AdminRepository : IAdminRepository
    {
        public List<Admin> GetAll()
        {
            Admin a = null;
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-3LQJUUD;Initial Catalog=SchoolDB;User ID=sa;Password=123");
            string query = "Select * from dbo.Admin";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            List<Admin> admins = new List<Admin>();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                int Id = (int)dr[0];
                int SchoolTypeId = (int)dr[1];
                string UserName = dr[2].ToString();
                int Password = (int)dr[3];
                int PhoneNumber = (int)dr[4];
                string Address = dr[5].ToString();
                admins.Add(a);
            }
            con.Close();
            return admins;
        }

        public Admin Get(int Id)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-3LQJUUD;Initial Catalog=SchoolDB;User ID=sa;Password=123");
            string query = "Select * from dbo.Admin Where Id = @Id";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Id", Id);
            con.Open();
            Admin a = null;
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                a = new Admin()
                {
                    Id = (int)dr[0],
                   SchoolTypeId = (int)dr[1],
                   UserName = dr[2].ToString(),
                     Password = (int)dr[3],
                      PhoneNumber = (int)dr[4],
                    Address = dr[5].ToString()
            };
                con.Close();
            }
            return a;
        }
        public bool Post(Admin a)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-3LQJUUD;Initial Catalog=SchoolDB;User ID=sa;Password=123");
            string query = "Insert into dbo.Admin (SchoolTypeId,UserName,Password,PhoneNumber,Address) Values(@SchoolTypeId,@UserName,@Password,@PhoneNumber,@Address)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@SchoolTypeId", a.SchoolTypeId);
            cmd.Parameters.AddWithValue("@UserName", a.UserName);
            cmd.Parameters.AddWithValue("@Password", a.Password);
            cmd.Parameters.AddWithValue("@PhoneNumber", a.PhoneNumber);
            cmd.Parameters.AddWithValue("@Address", a.Address);
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
        public bool Put(Admin a)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-3LQJUUD;Initial Catalog=SchoolDB;User ID=sa;Password=123");
            string query = ("Update dbo.Admin set SchoolTypeId=@SchoolTypeId,UserName=@UserName,Password=@Password,PhoneNumber=@PhoneNumber,Address=@Address Where Id = @Id");
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@SchoolTypeId", a.SchoolTypeId);
            cmd.Parameters.AddWithValue("@UserName", a.UserName);
            cmd.Parameters.AddWithValue("@Password", a.Password);
            cmd.Parameters.AddWithValue("@PhoneNumber", a.PhoneNumber);
            cmd.Parameters.AddWithValue("@Address", a.Address);
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
            string query = "Delete from dbo.Admin Where Id = @Id";
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
    