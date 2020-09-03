using SchoolDB.Contacts;
using SchoolDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SchoolDB.Controllers
{
    public class TeacherDetailsController : ApiController
    {
        public List<TeacherDetails> Get()
        {
            TeacherDetailsRepository teacher = new TeacherDetailsRepository();
            return teacher.GetAll();
        }
        public TeacherDetails Get(int Id)
        {
            TeacherDetailsRepository teacher = new TeacherDetailsRepository();
            return teacher.Get(Id);
        }
        [HttpPost]
        public bool Post(TeacherDetails teacherDetails)
        {

            TeacherDetailsRepository teacher = new TeacherDetailsRepository();
            return teacher.Post(teacherDetails);
        }
        [HttpPut]
        public bool Put(TeacherDetails teacherDetails)
        {
            TeacherDetailsRepository teacher = new TeacherDetailsRepository();
            return teacher.Put(teacherDetails);
        }
        [HttpDelete]
        public bool Delete(int Id)
        {
            TeacherDetailsRepository teacher = new TeacherDetailsRepository();
            return teacher.Delete(Id);
        }
    }
}


   