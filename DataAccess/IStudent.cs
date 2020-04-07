using DataAccess.DBEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public interface IStudent
    {
        public IEnumerable<StudentEntity> GetAllStudent();
    }
}
