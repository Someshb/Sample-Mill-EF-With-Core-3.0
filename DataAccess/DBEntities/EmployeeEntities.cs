using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataAccess.DBEntities
{
    public class EmployeeEntities 
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "varchar(60)")]
        public string Name { get; set; }

    }
}
