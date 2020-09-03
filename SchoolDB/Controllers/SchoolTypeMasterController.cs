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
    public class SchoolTypeMasterController : ApiController
    {
        public List<SchoolTypeMaster> Get()
        {
            SchoolTypeMasterRepository schoolType = new SchoolTypeMasterRepository();
            return schoolType.GetAll();
        }
        public SchoolTypeMaster Get(int Id)
        {

            SchoolTypeMasterRepository schoolType = new SchoolTypeMasterRepository();
            return schoolType.Get(Id);
        }
        [HttpPost]
        public bool Post(SchoolTypeMaster schoolTypeMaster)
        {


            SchoolTypeMasterRepository schoolType = new SchoolTypeMasterRepository();
            return schoolType.Post(schoolTypeMaster);
        }
        [HttpPut]
        public bool Put(SchoolTypeMaster schoolTypeMaster)
        {

            SchoolTypeMasterRepository schoolType = new SchoolTypeMasterRepository();
            return schoolType.Put(schoolTypeMaster);
        }
        [HttpDelete]
        public bool Delete(int Id)
        {

            SchoolTypeMasterRepository schoolType = new SchoolTypeMasterRepository();
            return schoolType.Delete(Id);
        }
    }
}


    
