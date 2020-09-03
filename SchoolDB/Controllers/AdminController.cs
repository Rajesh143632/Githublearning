using SchoolDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SchoolDB.Controllers
{
    public class AdminController : ApiController
    {
        public List<Admin> Get()
        {
            AdminRepository adminRepository = new AdminRepository();
            return adminRepository.GetAll();
        }
        public Admin Get(int Id)
        {
            AdminRepository adminRepository = new AdminRepository();
            return adminRepository.Get(Id);
        }
        [HttpPost]
        public bool Post(Admin a)
        {

            AdminRepository adminRepository = new AdminRepository();
            return adminRepository.Post(a);
        }
        [HttpPut]
        public bool Put(Admin a)
        {
            AdminRepository adminRepository = new AdminRepository();
            return adminRepository.Put(a);
        }
        [HttpDelete]
        public bool Delete(int Id)
        {
            AdminRepository adminRepository = new AdminRepository();
            return adminRepository.Delete(Id);
        }
    }
}

    
