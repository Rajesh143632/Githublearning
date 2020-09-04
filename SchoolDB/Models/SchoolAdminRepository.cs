using SchoolDB.Contacts;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SchoolDB.Models
{
    public class SchoolAdminRepository : ISchoolAdminRepository
    {
            public List<SchoolAdmin> GetAll()
            {
                
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-3LQJUUD;Initial Catalog=SchoolDB;User ID=sa;Password=123");
                string query = "Select * from dbo.SchoolAdmin";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
            List<SchoolAdmin> schoolAdmins = new List<SchoolAdmin>();
                SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                SchoolAdmin school = new SchoolAdmin()
                {
                   Id = (int)dr[0],
                     SchoolId = (int)dr[1],
                          SchoolName = dr[2].ToString(),
                      UserName = dr[3].ToString(),
                      Password = (int)dr[4],
                       PhoneNumber = (int)dr[5],
                 Address = dr[5].ToString(),
            };
                    schoolAdmins.Add(school);
                }
                con.Close();
                return schoolAdmins;
            }

            public SchoolAdmin Get(int Id)
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-3LQJUUD;Initial Catalog=SchoolDB;User ID=sa;Password=123");
                string query = "Select * from dbo.SchoolAdmin Where Id = @Id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Id", Id);
                con.Open();
                SchoolAdmin schoolAdmin = null;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    schoolAdmin = new SchoolAdmin()
                    {
                         Id = (int)dr[0],
                          SchoolId = (int)dr[1],
                       SchoolName = dr[2].ToString(),
                       UserName = dr[3].ToString(),
                        Password = (int)dr[4],
                         PhoneNumber = (int)dr[5],
                         Address = dr[5].ToString()
                 };
                    con.Close();
                }
                return schoolAdmin;
            }
            public bool Post(SchoolAdmin admin)
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-3LQJUUD;Initial Catalog=SchoolDB;User ID=sa;Password=123");
                string query = "Insert into dbo.SchoolAdmin (SchoolId,SchoolName,UserName,Password,PhoneNumber,Address) Values(@SchoolId,@SchoolName,@UserName,@Password,@PhoneNumber,@Address)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@SchoolId", admin.SchoolId);
                 cmd.Parameters.AddWithValue("@SchoolName", admin.SchoolName);
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
            public bool Put(SchoolAdmin admin)
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-3LQJUUD;Initial Catalog=SchoolDB;User ID=sa;Password=123");
                string query = ("Update dbo.SchoolAdmin Set SchoolId=@SchoolId,SchoolName=@SchoolName,UserName=@UserName,Password=@Password,PhoneNumber=@PhoneNumber,Address=@Address Where Id = @Id");
                SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Id", admin.Id);
            cmd.Parameters.AddWithValue("@SchoolId", admin.SchoolId);
            cmd.Parameters.AddWithValue("@SchoolName", admin.SchoolName);
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
                string query = "Delete from dbo.SchoolAdmin Where Id = @Id";
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

