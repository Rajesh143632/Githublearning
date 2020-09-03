using SchoolDB.Contacts;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SchoolDB.Models
{
    public class SchoolTypeMasterRepository : ISchoolTypeMasterRepository
    {
        public List<SchoolTypeMaster> GetAll()
        {
            SchoolTypeMaster schoolTypeMaster = null;
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-3LQJUUD;Initial Catalog=SchoolDB;User ID=sa;Password=123");
            string query = "Select * from dbo.SchoolTypeMaster";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            List<SchoolTypeMaster> schoolTypes = new List<SchoolTypeMaster>();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                int Id = (int)dr[0];
                string SchoolTypeName = dr[1].ToString();
                DateTime CreatedDateTime = (DateTime)dr[2];
                int CreatedBy = (int)dr[3];
                schoolTypes.Add(schoolTypeMaster);
            }
            con.Close();
            return schoolTypes;
        }

        public SchoolTypeMaster Get(int Id)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-3LQJUUD;Initial Catalog=SchoolDB;User ID=sa;Password=123");
            string query = "Select * from dbo.SchoolTypeMaster Where Id = @Id";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Id", Id);
            con.Open();
            SchoolTypeMaster schoolTypeMaster = null;
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                schoolTypeMaster = new SchoolTypeMaster
                {
                   Id = (int)dr[0],
                   SchoolTypeName = dr[1].ToString(),
                   CreatedDateTime = (DateTime)dr[2],
                 CreatedBy = (int)dr[3]

            };
                con.Close();
            }
            return schoolTypeMaster;
        }
        public bool Post(SchoolTypeMaster schoolTypeMaster)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-3LQJUUD;Initial Catalog=SchoolDB;User ID=sa;Password=123");
            string query = "Insert into dbo.SchoolTyppeMaster (SchoolTypeName,IsActive,CreatedDateTime,CreatedBy) Values(@SchoolTypeName,@IsActive,@CreatedDateTime,@CreatedBy)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@SchoolTypeName", schoolTypeMaster.SchoolTypeName);
            cmd.Parameters.AddWithValue("@IsActive", schoolTypeMaster.IsActive);
            cmd.Parameters.AddWithValue("@CreatedDateTime", schoolTypeMaster.CreatedDateTime);
            cmd.Parameters.AddWithValue("@CreatedBy", schoolTypeMaster.CreatedBy);
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
        public bool Put(SchoolTypeMaster schoolTypeMaster)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-3LQJUUD;Initial Catalog=SchoolDB;User ID=sa;Password=123");
            string query = ("Update dbo.SchoolTypeMaster SetSchoolTypeName=@SchoolTypeName,IsActive=@IsActive,CreatedDateTime=@CreatedDateTime,CreatedBy=@CreatedBy Where Id = @Id");
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Id", schoolTypeMaster.Id);
            cmd.Parameters.AddWithValue("@SchoolTypeName", schoolTypeMaster.SchoolTypeName);
            cmd.Parameters.AddWithValue("@IsActive", schoolTypeMaster.IsActive);
            cmd.Parameters.AddWithValue("@CreatedDateTime", schoolTypeMaster.CreatedDateTime);
            cmd.Parameters.AddWithValue("@CreatedBy", schoolTypeMaster.CreatedBy);
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
            string query = "Delete from dbo.SchoolTypeMaster Where Id = @Id";
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


    