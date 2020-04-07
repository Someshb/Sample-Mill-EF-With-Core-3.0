using DataAccess.DBEntities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.DbContexts
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options) : base(options)
        {

        }
        public DbSet<StudentEntity> StudentEntities { get; set; }
        public virtual DbSet<StudentEntity> GetStudentByID { get; set; }
        
    }
}
