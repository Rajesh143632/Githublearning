using SchoolDB.Contacts;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SchoolDB.Models
{
    public class StaffAdminRepository : IStaffAdminRepository
    {
        public List<StaffAdmin> GetAll()
        {
     
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-3LQJUUD;Initial Catalog=SchoolDB;User ID=sa;Password=123");
            string query = "Select * from dbo.StaffAdmin";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            List<StaffAdmin> staffAdmins = new List<StaffAdmin>();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                StaffAdmin staff = new StaffAdmin()
                {
                     Id = (int)dr[0],
                       StaffId = (int)dr[1],
                       DepartmentName = dr[2].ToString(),
                       StaffName = dr[3].ToString(),
                       UserName = dr[4].ToString(),
                       Password = (int)dr[5],
                        PhoneNumber = (int)dr[6],
                        Address = dr[5].ToString(),
            };
                staffAdmins.Add(staff);
            }
            con.Close();
            return staffAdmins;
        }

        public StaffAdmin Get(int Id)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-3LQJUUD;Initial Catalog=SchoolDB;User ID=sa;Password=123");
            string query = "Select * from dbo.StaffAdmin Where Id = @Id";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Id", Id);
            con.Open();
            StaffAdmin staffAdmin = null;
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                staffAdmin = new StaffAdmin()
                {
                      Id = (int)dr[0],
                     StaffId = (int)dr[1],
                    DepartmentName = dr[2].ToString(),
                      StaffName = dr[3].ToString(),
                    UserName = dr[4].ToString(),
                    Password = (int)dr[5],
                      PhoneNumber = (int)dr[6],
                 Address = dr[5].ToString()
            };
                con.Close();
            }
            return staffAdmin;
        }
        public bool Post(StaffAdmin admin)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-3LQJUUD;Initial Catalog=SchoolDB;User ID=sa;Password=123");
            string query = "Insert into dbo.StaffAdmin (StaffId,DepartmentName,StaffName,UserName,Password,PhoneNumber,Address) Values(@StaffId,@DepartmentName,@StaffName,@UserName,@Password,@PhoneNumber,@Address)";
            SqlCommand cmd = new SqlCommand(query, con);
        
            cmd.Parameters.AddWithValue("@StaffId", admin.StaffId);
            cmd.Parameters.AddWithValue("@DepartmentName", admin.DepartmentName);
            cmd.Parameters.AddWithValue("@StaffName", admin.StaffName);
            cmd.Parameters.AddWithValue("@UserName", admin.UserName);
            cmd.Parameters.AddWithValue("@Password", admin.Password);
            cmd.Parameters.AddWithValue("@PhoneNumber", admin.PhoneNumber);
            cmd.Parameters.AddWithValue("@Address", admin.Address);
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
        public bool Put(StaffAdmin admin)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-3LQJUUD;Initial Catalog=SchoolDB;User ID=sa;Password=123");
            string query = ("Update dbo.StaffAdmin Set StaffId=@StaffId,DepartmentName=@DepartmentName,StaffName=@StaffName,UserName=@UserName,Password=@Password,PhoneNumber=@PhoneNumber,Address=@Address Where Id = @Id");
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Id", admin.Id);
            cmd.Parameters.AddWithValue("@StaffId", admin.StaffId);
            cmd.Parameters.AddWithValue("@DepartmentName", admin.DepartmentName);
            cmd.Parameters.AddWithValue("@StaffName", admin.StaffName);
            cmd.Parameters.AddWithValue("@UserName", admin.UserName);
            cmd.Parameters.AddWithValue("@Password", admin.Password);
            cmd.Parameters.AddWithValue("@PhoneNumber", admin.PhoneNumber);
            cmd.Parameters.AddWithValue("@Address", admin.Address);
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
            string query = "Delete from dbo.StaffAdmin Where Id = @Id";
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

    