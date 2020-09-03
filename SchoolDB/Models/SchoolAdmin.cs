using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolDB.Models
{
    public class SchoolAdmin
    {
        public int Id { get; set; }

        public int SchoolId { get; set; }

        public string SchoolName { get; set; }

        public string UserName { get; set; }

        public int Password { get; set; }

        public int PhoneNumber { get; set; }

        public string Address { get; set; }

    }
}