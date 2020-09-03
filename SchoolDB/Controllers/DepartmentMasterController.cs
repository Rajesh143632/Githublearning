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
    public class DepartmentMasterController : ApiController
    {
        public List<DepartmentMaster> Get()
        {
            DepartmentMasterRepository department = new DepartmentMasterRepository();      
            return department.GetAll();
        }
        public DepartmentMaster Get(int Id)
        {
            DepartmentMasterRepository department = new DepartmentMasterRepository();
            return department.Get(Id);
        }
        [HttpPost]
        public bool Post(DepartmentMaster departmentMaster)
        {
            DepartmentMasterRepository department = new DepartmentMasterRepository();

            return department.Post(departmentMaster);
        }
        [HttpPut]
        public bool Put(DepartmentMaster departmentMaster)
        {
            DepartmentMasterRepository department = new DepartmentMasterRepository();
            return department.Put(departmentMaster);
        }
    }
}

