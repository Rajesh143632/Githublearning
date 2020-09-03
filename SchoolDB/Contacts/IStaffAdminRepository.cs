using SchoolDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolDB.Contacts
{
    public interface IStaffAdminRepository
    {
        List<StaffAdmin> GetAll();
        StaffAdmin Get(int Id);
        bool Post(StaffAdmin admin);
        bool Put(StaffAdmin admin);
        bool Delete(int Id);
    }
}