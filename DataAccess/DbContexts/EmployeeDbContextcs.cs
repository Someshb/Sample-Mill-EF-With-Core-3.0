using DataAccess.DBEntities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;


namespace DataAccess.DbContexts 
{
    class EmployeeDbContextcs : DbContext
    {
        public EmployeeDbContextcs(DbContextOptions<StudentContext> options) : base(options)
        {

        }


        public DbSet<StudentEntity> EmployeeEntities { get; set; }
        //public virtual DbSet<StudentEntity> GetStudentByID { get; set; }

    }
}
