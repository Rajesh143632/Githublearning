using SchoolDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolDB.Contacts
{
    public interface IDepartmentMasterRepository
    {
        List<DepartmentMaster> GetAll();
        DepartmentMaster Get(int Id);
        bool Post(DepartmentMaster departmentMaster);
        bool Put(DepartmentMaster departmentMaster);
    }
}