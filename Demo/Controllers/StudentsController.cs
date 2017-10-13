using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Demo.Models;
using System.Web.Http.Cors;

namespace Demo.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class StudentsController : ApiController
    {
        private StudentContext db = new StudentContext();

        public IHttpActionResult Get()
        {
            var p = db.Students.ToList();
            return Ok(p);
        }

        // GET: api/Crud/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Crud
        public IHttpActionResult PostStudent(Student student)
        {
            db.Students.Add(student);
            db.SaveChanges();
            return Ok("Ok");
        }

        // PUT: api/Crud/5
        public IHttpActionResult PutStudent(Student student)
        {

            var res = db.Students.Find(student.Id);
            res.FirstName = student.FirstName;
            res.LastName = student.LastName;
            res.Email = student.Email;

            db.SaveChanges();
            return Ok("Ok");
        }

        // DELETE: api/Crud/5
        public IHttpActionResult DeleteStudent(int id)
        {
            var res = db.Students.Find(id);
            db.Students.Remove(res);
            db.SaveChanges();
            return Ok("ok");

        }
    }
}