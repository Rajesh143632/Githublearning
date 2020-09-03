using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolDB.Models
{
    public class PiuneDetails
    {
        public int Id { get; set; }

        public string PiuneName { get; set; }

        public int SchoolId { get; set; }

        public string Address { get; set; }

        public int Salary { get; set; }

        public int DepartmentId { get; set; }

        public int Age { get; set; }

        public string Gender { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Country { get; set; }

        public bool IsActive { get; set; }

        public DateTime CreatedDateTime { get; set; }

        public int ContactId { get; set; }

        public int CreatedBy { get; set; }
    }
}