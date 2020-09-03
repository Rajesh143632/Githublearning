using SchoolDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolDB.Contacts
{
    public interface ISecurityStaffDetailsRepository
    {

        List<SecurityStaffDetails> GetAll();
        SecurityStaffDetails Get(int Id);
        bool Post(SecurityStaffDetails securityStaffDetails);
        bool Put(SecurityStaffDetails securityStaffDetails);
        bool Delete(int Id);
    }
}
