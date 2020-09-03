using SchoolDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolDB.Contacts
{
    public interface IContactMasterRepository
    {
        List<ContactMaster> GetAll();
        ContactMaster Get(int Id);
        bool Post(ContactMaster contactMaster);
        bool Put(ContactMaster contactMaster);
       bool Delete(int Id);
    }
}