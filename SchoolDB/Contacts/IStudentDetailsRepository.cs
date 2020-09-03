using SchoolDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolDB.Contacts
{
    public interface IStudentDetailsRepository
    {

        List<StudentDetails> GetAll();
        StudentDetails Get(int Id);
        bool Post(StudentDetails studentDetails);
        bool Put(StudentDetails studentDetails);
        bool Delete(int Id);
    }
}