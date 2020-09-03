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
    public class SchoolDetailsController : ApiController
    {
            public List<SchoolDetails> Get()
            {
            SchoolDetailsRepository school = new SchoolDetailsRepository();
                return school.GetAll();
            }
            public SchoolDetails Get(int Id)
            {
            SchoolDetailsRepository school = new SchoolDetailsRepository();
            return school.Get(Id);
            }
        [HttpPost]
            public bool Post(SchoolDetails schoolDetails)
            {

            SchoolDetailsRepository school = new SchoolDetailsRepository();
            return school.Post(schoolDetails);
            }
        [HttpPut]
            public bool Put(SchoolDetails schoolDetails)
            {
            SchoolDetailsRepository school = new SchoolDetailsRepository();
            return school.Put(schoolDetails);
            }
        [HttpDelete]
            public bool Delete(int Id)
            {
            SchoolDetailsRepository school = new SchoolDetailsRepository();
            return school.Delete(Id);
            }
        }
    }




