using SchoolDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolDB.Contacts
{
    public interface ISchoolTypeMasterRepository
    {
        List<SchoolTypeMaster> GetAll();
        SchoolTypeMaster Get(int Id);
        bool Post(SchoolTypeMaster schoolTypeMaster);
        bool Put(SchoolTypeMaster schoolTypeMaster);
        bool Delete(int Id);
    }
}