using CodeFirt.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirt.Data
{
    public class CollegeContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Subject> Subjects { get; set; } 
        public DbSet<SubjectStudent> SubjectStudents { get; set; }

        public CollegeContext(DbContextOptions options) : base(options)
        {

        }



    }
}
