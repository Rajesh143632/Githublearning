using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication25.Models;

namespace WebApplication25.Controllers
{
    public class StudentController : ApiController
    {
        List<Student> student = new List<Student>();

        public StudentController()
        {
            student.Add(new Student { Username = "Raju", Password = "Ohm", Id = 1 });
            student.Add(new Student { Username = "Kiran", Password = "Beam", Id = 2 });
            student.Add(new Student { Username = "Raj", Password = "Ullu", Id = 3 });
        }
        // GET: api/Student
        public List<Student> Get()
        {
            return student;
        }

        // GET: api/Student/5
        public Student Get(int id)
        {
            return student.Where(x => x.Id == id).FirstOrDefault();
        }

        // POST: api/Student
        public void Post(Student value)
        {
            student.Add(value);
        }

        // PUT: api/Student/5
        public void Put(int id)
        {

        }

        // DELETE: api/Student/5
        public void Delete(int id)
        {
           
        }
    }
}
