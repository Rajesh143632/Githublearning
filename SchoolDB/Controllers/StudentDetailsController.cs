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
    public class StudentDetailsController : ApiController
    {
        public List<StudentDetails> Get()
        {
            StudentDetailsRepository student = new StudentDetailsRepository();
            return student.GetAll();
        }
        public StudentDetails Get(int Id)
        {
            StudentDetailsRepository student = new StudentDetailsRepository();
            return student.Get(Id);
        }
        [HttpPost]
        public bool Post(StudentDetails studentDetails)
        {

            StudentDetailsRepository student = new StudentDetailsRepository();
            return student.Post(studentDetails);
        }
        [HttpPut]
        public bool Put(StudentDetails studentDetails)
        {
            StudentDetailsRepository student = new StudentDetailsRepository();
            return student.Put(studentDetails);
        }
        [HttpDelete]
        public bool Delete(int Id)
        {
            StudentDetailsRepository student = new StudentDetailsRepository();
            return student.Delete(Id);
        }
    }
}



