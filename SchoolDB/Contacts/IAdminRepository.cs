using SchoolDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolDB.Contacts
{
    public interface IAdminRepository
    {
        List<Admin> GetAll();
        Admin Get(int Id);
        bool Post(Admin a);
        bool Put(Admin a);
        bool Delete(int Id);
    }
}