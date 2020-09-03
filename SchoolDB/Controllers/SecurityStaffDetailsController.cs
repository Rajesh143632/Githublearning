using SchoolDB.Contacts;
using SchoolDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SchoolDB.Controllers
{
    public class SecurityStaffDetailsController : ApiController
    {
        public List<SecurityStaffDetails> Get()
        {
            SecurityStaffDetailsRepository security = new SecurityStaffDetailsRepository();
            return security.GetAll();
        }
        public SecurityStaffDetails Get(int Id)
        {
            SecurityStaffDetailsRepository security = new SecurityStaffDetailsRepository();
            return security.Get(Id);
        }
        [HttpPost]
        public bool Post(SecurityStaffDetails securityStaffDetails)
        {

            SecurityStaffDetailsRepository security = new SecurityStaffDetailsRepository();
            return security.Post(securityStaffDetails);
        }
        [HttpPut]
        public bool Put(SecurityStaffDetails securityStaffDetails)
        {
            SecurityStaffDetailsRepository security = new SecurityStaffDetailsRepository();
            return security.Put(securityStaffDetails);
        }
        [HttpDelete]
        public bool Delete(int Id)
        {
            SecurityStaffDetailsRepository security = new SecurityStaffDetailsRepository();
            return security.Delete(Id);
        }
    }
}


