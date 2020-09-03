using SchoolDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SchoolDB.Controllers
{
    public class SchoolAdminController : ApiController
    {
        public List<SchoolAdmin> Get()
        {
            SchoolAdminRepository adminRepository = new SchoolAdminRepository();
            return adminRepository.GetAll();
        }
        public SchoolAdmin Get(int Id)
        {
            SchoolAdminRepository adminRepository = new SchoolAdminRepository();
            return adminRepository.Get(Id);
        }
        [HttpPost]
        public bool Post(SchoolAdmin admin)
        {

            SchoolAdminRepository adminRepository = new SchoolAdminRepository();
            return adminRepository.Post(admin);
        }
        [HttpPut]
        public bool Put(SchoolAdmin admin)
        {
            SchoolAdminRepository adminRepository = new SchoolAdminRepository();
            return adminRepository.Put(admin);
        }
        [HttpDelete]
        public bool Delete(int Id)
        {
            SchoolAdminRepository adminRepository = new SchoolAdminRepository();
            return adminRepository.Delete(Id);
        }
    }
}

    
    
