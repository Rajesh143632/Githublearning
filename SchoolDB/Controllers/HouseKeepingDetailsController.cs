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
    public class HouseKeepingDetailsController : ApiController
    {
        public List<HouseKeepingDetails> Get()
        {
            HouseKeepingDetailsRepository house = new HouseKeepingDetailsRepository();
            return house.GetAll();
        }
        public HouseKeepingDetails Get(int Id)
        {
            HouseKeepingDetailsRepository house = new HouseKeepingDetailsRepository();
            return house.Get(Id);
        }
        [HttpPost]
        public bool Post(HouseKeepingDetails houseKeepingDetails)
        {
            HouseKeepingDetailsRepository house = new HouseKeepingDetailsRepository();
            return house.Post(houseKeepingDetails);
        }
        [HttpPut]
        public bool Put(HouseKeepingDetails houseKeepingDetails)
        {
            HouseKeepingDetailsRepository house = new HouseKeepingDetailsRepository();

            return house.Put(houseKeepingDetails);
        }
        [HttpDelete]
        public bool Delete(int Id)
        {
            HouseKeepingDetailsRepository house = new HouseKeepingDetailsRepository();
            return house.Delete(Id);
        }
    }
}

