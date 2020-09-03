using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolDB.Models
{
    public class SchoolDetails
    {
        public int Id { get; set; }

        public string SchoolName { get; set; }

        public int SchoolTypeId { get; set; }

        public DateTime CreatedDateTime { get; set; }

        public  bool IsActive { get; set; }

        public string SchoolAddress { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Country { get; set; }

        public int CreatedBy { get; set; }
    }
}