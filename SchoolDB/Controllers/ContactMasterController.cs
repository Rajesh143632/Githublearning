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
    public class ContactMasterController : ApiController
        {

        public List<ContactMaster> Get()
            {
            ContactMasterRepository contact = new ContactMasterRepository();
            return contact.GetAll();
            }
            public ContactMaster Get(int Id)
            {
            ContactMasterRepository contact = new ContactMasterRepository();
            return contact.Get(Id);
            }
        [HttpPost]
            public bool Post(ContactMaster contactMaster)
            {

            ContactMasterRepository contact = new ContactMasterRepository();
            return contact.Post(contactMaster);
            }
        [HttpPut]
            public bool Put(ContactMaster contactMaster)
            {
            ContactMasterRepository contact = new ContactMasterRepository();
            return contact.Put(contactMaster);
            }
        [HttpDelete]
            public bool Delete(int Id)
            {
            ContactMasterRepository contact = new ContactMasterRepository();
            return contact.Delete(Id);
            }
        }
    }

