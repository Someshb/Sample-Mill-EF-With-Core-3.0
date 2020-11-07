using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mill_App_02.Models
{
    public class StudentVM
    {
       
        public int Id { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public string Class { get; set; }
        public List<StudentVM> StudentList { get; set; }
    }
}
