using SchoolDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SchoolDB.Controllers
{
    public class StaffAdminController : ApiController
    {
        public List<StaffAdmin> Get()
        {
            StaffAdminRepository adminRepository = new StaffAdminRepository();
            return adminRepository.GetAll();
        }
        public StaffAdmin Get(int Id)
        {
            StaffAdminRepository adminRepository = new StaffAdminRepository();
            return adminRepository.Get(Id);
        }
        [HttpPost]
        public bool Post(StaffAdmin admin)
        {

            StaffAdminRepository adminRepository = new StaffAdminRepository();
            return adminRepository.Post(admin);
        }
        [HttpPut]
        public bool Put(StaffAdmin admin)
        {
            StaffAdminRepository adminRepository = new StaffAdminRepository();
            return adminRepository.Put(admin);
        }
        [HttpDelete]
        public bool Delete(int Id)
        {
            StaffAdminRepository adminRepository = new StaffAdminRepository();
            return adminRepository.Delete(Id);
        }
    }
}

    

  
