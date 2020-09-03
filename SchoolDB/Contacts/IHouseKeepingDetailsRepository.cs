using SchoolDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolDB.Contacts
{
    public interface IHouseKeepingDetailsRepository
    {
        List<HouseKeepingDetails> GetAll();
        HouseKeepingDetails Get(int Id);
        bool Post(HouseKeepingDetails houseKeepingDetails);
        bool Put(HouseKeepingDetails houseKeepingDetails);
        bool Delete(int Id);
    }
}