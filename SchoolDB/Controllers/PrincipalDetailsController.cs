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
    public class PrincipalDetailsController : ApiController
    {
      
        public List<PrincipalDetails> Get()
        {
            PrincipalDetailsRepository principal = new PrincipalDetailsRepository();
            return principal.GetAll();
        }
        public PrincipalDetails Get(int Id)
        {
            PrincipalDetailsRepository principal = new PrincipalDetailsRepository();
            return principal.Get(Id);
        }
        [HttpPost]
        public bool Post(PrincipalDetails principalDetails)
        {
            PrincipalDetailsRepository principal = new PrincipalDetailsRepository();
            return principal.Post(principalDetails);
        }
        [HttpPut]
        public bool Put(PrincipalDetails principalDetails)
        {
            PrincipalDetailsRepository principal = new PrincipalDetailsRepository();
            return principal.Put(principalDetails);
        }
        [HttpDelete]
        public bool Delete(int Id)
        {
            PrincipalDetailsRepository principal = new PrincipalDetailsRepository();
            return principal.Delete(Id);
        }
    }
}


