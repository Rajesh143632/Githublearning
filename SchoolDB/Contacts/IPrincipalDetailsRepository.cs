using SchoolDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolDB.Contacts
{
    public interface IPrincipalDetailsRepository
    {
        List<PrincipalDetails> GetAll();
        PrincipalDetails Get(int Id);
        bool Post(PrincipalDetails principalDetails);
        bool Put(PrincipalDetails principalDetails);
        bool Delete(int Id);
    }
}