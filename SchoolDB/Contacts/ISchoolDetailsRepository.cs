using SchoolDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolDB.Contacts
{
    public interface ISchoolDetailsRepository
    {
        List<SchoolDetails> GetAll();
        SchoolDetails Get(int Id);
        bool Post(SchoolDetails schoolDetails);
        bool Put(SchoolDetails schoolDetails);
        bool Delete(int Id);
    }
}