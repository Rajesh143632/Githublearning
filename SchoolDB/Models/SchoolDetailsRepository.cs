using SchoolDB.Contacts;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SchoolDB.Models
{
    public class SchoolDetailsRepository : ISchoolDetailsRepository
    {
            public List<SchoolDetails> GetAll()
            {
                SchoolDetails schoolDetails = null;
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-3LQJUUD;Initial Catalog=SchoolDB;User ID=sa;Password=123");
                string query = "Select * from dbo.SchoolDetails";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                List<SchoolDetails> schools = new List<SchoolDetails>();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int Id = (int)dr[0];
                    string SchoolName = dr[1].ToString();
                    int SchoolTypeId = (int)dr[2];
                     DateTime CreatedDateTime = (DateTime)dr[3];
                    string SchoolAddress = dr[4].ToString();
                    string City = dr[5].ToString();
                    string State = dr[6].ToString();
                    string Country = dr[7].ToString();           
                   int CreatedBy = (int)dr[8];
                    schools.Add(schoolDetails);
                }
                con.Close();
                return schools;
            }

            public SchoolDetails Get(int Id)
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-3LQJUUD;Initial Catalog=SchoolDB;User ID=sa;Password=123");
                string query = "Select * from dbo.SchoolDetails Where Id = @Id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Id", Id);
                con.Open();
                SchoolDetails schoolDetails = null;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    schoolDetails = new SchoolDetails
                    {
                        Id = (int)dr[0],
                       SchoolName = dr[1].ToString(),
                       SchoolTypeId = (int)dr[2],
                       CreatedDateTime = (DateTime)dr[3],
                      SchoolAddress = dr[4].ToString(),
                        City = dr[5].ToString(),
                         State = dr[6].ToString(),
                           Country = dr[7].ToString(),
                        CreatedBy = (int)dr[8]

            };
                    con.Close();
                }
                return schoolDetails;
            }
            public bool Post(SchoolDetails schoolDetails)
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-3LQJUUD;Initial Catalog=SchoolDB;User ID=sa;Password=123");
                string query = "Insert into dbo.SchoolDetails (SchoolName,SchoolTypeId,CreatedDateTime,IsActive,SchoolAddress,City,State,Country,CreatedBy) Values(@SchoolName,@SchoolTypeId,@CreatedDateTime,@IsActive,@SchoolAddress,@City,@State,@Country,@CreatedBy)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@SchoolName", schoolDetails.SchoolName);
                cmd.Parameters.AddWithValue("@SchoolTypeId", schoolDetails.SchoolTypeId);
                cmd.Parameters.AddWithValue("@CreatedDateTime", schoolDetails.CreatedDateTime);
                cmd.Parameters.AddWithValue("@IsActive", schoolDetails.IsActive);
                cmd.Parameters.AddWithValue("@SchoolAddress", schoolDetails.SchoolAddress);
                cmd.Parameters.AddWithValue("@City", schoolDetails.City);
                cmd.Parameters.AddWithValue("@State", schoolDetails.State);
                cmd.Parameters.AddWithValue("@Country", schoolDetails.Country);
                cmd.Parameters.AddWithValue("@CreatedBy", schoolDetails.CreatedBy);
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
            public bool Put(SchoolDetails schoolDetails)
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-3LQJUUD;Initial Catalog=SchoolDB;User ID=sa;Password=123");
                string query = ("Update dbo.SchoolDetails Set SchoolName=@SchoolName,SchoolTypeId=@SchoolTypeId,CreatedDateTime=@CreatedDateTime,IsActive=@IsActive,SchoolAddress=@SchoolAddress,City=@City,State=@State,Country=@Country,CreatedBy=@CreatedBy  Where Id = @Id");
                SqlCommand cmd = new SqlCommand(query, con);
              cmd.Parameters.AddWithValue("@Id", schoolDetails.Id);
              cmd.Parameters.AddWithValue("@SchoolName", schoolDetails.SchoolName);
              cmd.Parameters.AddWithValue("@SchoolTypeId", schoolDetails.SchoolTypeId);
              cmd.Parameters.AddWithValue("@CreatedDateTime", schoolDetails.CreatedDateTime);
              cmd.Parameters.AddWithValue("@IsActive", schoolDetails.IsActive);
              cmd.Parameters.AddWithValue("@SchoolAddress", schoolDetails.SchoolAddress);
              cmd.Parameters.AddWithValue("@City", schoolDetails.City);
              cmd.Parameters.AddWithValue("@State", schoolDetails.State);
              cmd.Parameters.AddWithValue("@Country", schoolDetails.Country);
              cmd.Parameters.AddWithValue("@CreatedBy", schoolDetails.CreatedBy);
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
                string query = "Delete from dbo.SchoolDetails Where Id = @Id";
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




