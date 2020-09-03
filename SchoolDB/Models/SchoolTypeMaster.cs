using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolDB.Models
{
    public class SchoolTypeMaster
    {
        public int Id { get; set; }

        public string SchoolTypeName { get; set; }

        public bool IsActive { get; set; }

        public DateTime CreatedDateTime { get; set; }

        public int CreatedBy { get; set; }
    }
}