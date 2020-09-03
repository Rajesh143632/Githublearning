using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolDB.Models
{
    public class StaffAdmin
    {
        public int Id { get; set; }

        public int StaffId { get; set; }

        public string DepartmentName { get; set; }

        public string StaffName { get; set; }

        public string UserName { get; set; }

        public  int Password { get; set; }

        public  int PhoneNumber { get; set; }

        public string Address { get; set; }
    }
}