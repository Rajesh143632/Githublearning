using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolDB.Models
{
    public class ContactMaster
    {
        public int Id { get; set; }

        public string ContactDetails { get; set; }

        public int PhoneNumber { get; set; }

        public int MobileNumber { get; set; }

        public int CreatedBy { get; set; }
    }
}