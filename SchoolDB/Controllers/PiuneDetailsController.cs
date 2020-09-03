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
    public class PiuneDetailsController : ApiController
    {
        public List<PiuneDetails> Get()
        {
            PiuneDetailsRepository piune = new PiuneDetailsRepository();
            return piune.GetAll();
        }
        public PiuneDetails Get(int Id)
        {

            PiuneDetailsRepository piune = new PiuneDetailsRepository();
            return piune.Get(Id);
        }
        [HttpPost]
        public bool Post(PiuneDetails piuneDetails)
        {

            PiuneDetailsRepository piune = new PiuneDetailsRepository();
            return piune.Post(piuneDetails);
        }
        [HttpPut]
        public bool Put(PiuneDetails piuneDetails)
        {

            PiuneDetailsRepository piune = new PiuneDetailsRepository();
            return piune.Put(piuneDetails);
        }
        [HttpDelete]
        public bool Delete(int Id)
        {

            PiuneDetailsRepository piune = new PiuneDetailsRepository();
            return piune.Delete(Id);
        }
    }
}
