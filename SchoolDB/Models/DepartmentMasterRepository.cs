using SchoolDB.Contacts;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SchoolDB.Models
{
    public class DepartmentMasterRepository : IDepartmentMasterRepository
    {
        public List<DepartmentMaster> GetAll()
        {
            DepartmentMaster department = null;
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-3LQJUUD;Initial Catalog=SchoolDB;User ID=sa;Password=123");
            string query = "Select * from dbo.DepartmentMaster";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            List<DepartmentMaster> departmentMasters = new List<DepartmentMaster>();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                 int Id = (int)dr[0];
                string DepartmentName = dr[1].ToString();
                bool IsActive = (bool)dr[2];
                DateTime CreatedDateTime = (DateTime)dr[3];
                int CreatedBy = (int)dr[4];
                departmentMasters.Add(department);
             }
            con.Close();
            return departmentMasters;
        }
    

        public DepartmentMaster Get(int Id)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-3LQJUUD;Initial Catalog=SchoolDB;User ID=sa;Password=123");
            string query = "Select * from dbo.DepartmentMaster Where Id = @Id";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Id", Id);
            con.Open();
            DepartmentMaster departmentMaster = null;
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                departmentMaster = new DepartmentMaster
                {

                    Id = (int)dr[0],
                    DepartmentName = dr[1].ToString(),
                    IsActive = (bool)dr[2],
                    CreatedDateTime = (DateTime)dr[3],
                    CreatedBy = (int)dr[4],
            };
                con.Close();
            }
            return departmentMaster;
        }
        public bool Post(DepartmentMaster departmentMaster)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-3LQJUUD;Initial Catalog=SchoolDB;User ID=sa;Password=123");
            string query = "Insert into dbo.DepartmentMaster (DepartmentName,CreatedDateTime,CreatedBy) Values(@DepartmentName,@CreatedDateTime,@CreatedBy)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@DepartmentName", departmentMaster.DepartmentName);
            cmd.Parameters.AddWithValue("@CreatedDateTime", departmentMaster.CreatedDateTime);
            cmd.Parameters.AddWithValue("@CreatedBy", departmentMaster.CreatedBy);
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
        public bool Put(DepartmentMaster departmentMaster)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-3LQJUUD;Initial Catalog=SchoolDB;User ID=sa;Password=123");
            string query = ("Update dbo.DepartmentMaster set DepartmentName=@DepartmentName,CreatedDateTime=@CreatedDateTime,CreatedBy=@CreatedBy Where Id = @Id");
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Id", departmentMaster.Id);
            cmd.Parameters.AddWithValue("@DepartmentName", departmentMaster.DepartmentName);
            cmd.Parameters.AddWithValue("@CreatedDateTime", departmentMaster.CreatedDateTime);
            cmd.Parameters.AddWithValue("@CreatedBy", departmentMaster.CreatedBy);
            con.Open();
            int noOfRowAffected = cmd.ExecuteNonQuery();
            con.Close();
            if(noOfRowAffected > 0)
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
