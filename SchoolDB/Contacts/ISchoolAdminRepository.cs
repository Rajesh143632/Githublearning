using SchoolDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolDB.Contacts
{
    public interface ISchoolAdminRepository
    {
        List<SchoolAdmin> GetAll();
        SchoolAdmin Get(int Id);
        bool Post(SchoolAdmin admin);
        bool Put(SchoolAdmin admin);
        bool Delete(int Id);
    }
}