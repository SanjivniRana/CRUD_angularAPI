using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Demo.Models
{
    public class StudentContext : DbContext
    {
        public StudentContext() : base("MyConnection") { }

        public DbSet<Student> Students { get; set; }
    }
}