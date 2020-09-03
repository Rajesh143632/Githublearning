using SchoolDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolDB.Contacts
{
    public interface IPiuneDetailsRepository
    {
        List<PiuneDetails> GetAll();
        PiuneDetails Get(int Id);
        bool Post(PiuneDetails piuneDetails);
        bool Put(PiuneDetails piuneDetails);
        bool Delete(int Id);
    }
}