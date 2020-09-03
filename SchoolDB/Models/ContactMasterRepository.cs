using SchoolDB.Contacts;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SchoolDB.Models
{
    public class ContactMasterRepository : IContactMasterRepository
    {
        public List<ContactMaster> GetAll()
        {
            ContactMaster contactMaster = null;
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-3LQJUUD;Initial Catalog=SchoolDB;User ID=sa;Password=123");
            string query = "Select * from dbo.ContactMaster";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            List<ContactMaster> contactMasters = new List<ContactMaster>();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                int Id = (int)dr[0];
                string ContactDetails = dr[1].ToString();
                int PhoneNumber = (int)dr[2];
                int MobileNumber = (int)dr[3];
                int CreatedBy = (int)dr[4];
                contactMasters.Add(contactMaster);
            }
            con.Close();
            return contactMasters;
        }

        public ContactMaster Get(int Id)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-3LQJUUD;Initial Catalog=SchoolDB;User ID=sa;Password=123");
            string query = "Select * from dbo.ContactMaster Where Id = @Id";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Id", Id);
            con.Open();
            ContactMaster contactMaster = null;
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                contactMaster = new ContactMaster
                {
                    Id = (int)dr[0],
                    ContactDetails = dr[1].ToString(),
                    PhoneNumber = (int)dr[2],
                    MobileNumber = (int)dr[3],
                    CreatedBy = (int)dr[4],
                };
                con.Close();
            }
            return contactMaster;
        }
        public bool Post(ContactMaster contactMaster)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-3LQJUUD;Initial Catalog=SchoolDB;User ID=sa;Password=123");
            string query = "Insert into dbo.ContactMaster (ContactDetails,PhoneNumber,MobileNUmber,CreatedBy) Values(@ContactDetails,@PhoneNumber,@MobileNumber,@CreatedBy)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@ContactDetails", contactMaster.ContactDetails);
            cmd.Parameters.AddWithValue("@PhoneNumber", contactMaster.PhoneNumber);
            cmd.Parameters.AddWithValue("@MobileNumber", contactMaster.MobileNumber);
            cmd.Parameters.AddWithValue("@CreatedBy", contactMaster.CreatedBy);
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
        public bool Put(ContactMaster contactMaster)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-3LQJUUD;Initial Catalog=SchoolDB;User ID=sa;Password=123");
            string query = ("Update dbo.ContactMaster set ContactDetails=@ContactDetails,PhoneNumber=@PhoneNumber,MobileNUmber=@MobileNumber,CreatedBy=@CreatedBy Where Id = @Id");
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Id", contactMaster.Id);
            cmd.Parameters.AddWithValue("@ContactDetails", contactMaster.ContactDetails);
            cmd.Parameters.AddWithValue("@PPhoneNumber", contactMaster.PhoneNumber);
            cmd.Parameters.AddWithValue("@MobileNumber", contactMaster.MobileNumber);
            cmd.Parameters.AddWithValue("@CreatedBy", contactMaster.CreatedBy);
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
            string query = "Delete from dbo.ContactMaster Where Id = @Id";
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
