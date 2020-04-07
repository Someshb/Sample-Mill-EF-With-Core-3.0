using DataAccess.DBEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public interface IPropertyInfo
    {
        public PropertyInfoEntity GetAllStudentById(int Id);
        public IEnumerable<PropertyInfoEntity> GetAllStudent();
    }
}
