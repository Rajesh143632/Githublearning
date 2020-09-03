using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolDB.Models
{
    public class Admin
    {
        public int Id { get; set; }

        public int SchoolTypeId { get; set; }

        public string UserName { get; set; }

        public int Password { get; set; }

        public int PhoneNumber { get; set; }

        public string Address { get; set; }
    }
}