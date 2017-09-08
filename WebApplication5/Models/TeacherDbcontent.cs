using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApplication5.Models
{
    public class TeacherDbcontent:DbContext
    {
        public TeacherDbcontent():base("DefaultConnection")
        { }
        public DbSet<teacher> teachers { get; set; }
    }
}