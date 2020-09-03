using SchoolDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolDB.Contacts
{
    public interface ITeacherDetailsRepository
    {

        List<TeacherDetails> GetAll();
        TeacherDetails Get(int Id);
        bool Post(TeacherDetails teacherDetails);
        bool Put(TeacherDetails teacherDetails);
        bool Delete(int Id);
    }
}