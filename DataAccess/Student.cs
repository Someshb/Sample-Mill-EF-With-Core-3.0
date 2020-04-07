using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Dapper;
using DataAccess.DBEntities;
using Microsoft.Extensions.Configuration;

namespace DataAccess
{
    public class Student : IStudent
    {
        private string _connectionString;
        private readonly IConfiguration _config;
        public Student(IConfiguration config)
        {
            //_connectionString = " Data Source=DESKTOP-C8GAGRL;Initial Catalog=Clubman.Ntier.SampleDB; "
            //  + "Integrated Security=true";
            _config = config;

        }
        public IEnumerable<StudentEntity> GetAllStudent()
        {
            var Query = new StringBuilder();
            IEnumerable<StudentEntity> result = null;
            try
            {
                
                using (SqlConnection conn = Connection)
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                        string sQuery = "TestProc";
                        DynamicParameters parameter = new DynamicParameters();

                        result = conn.Query<StudentEntity>(sQuery,CommandType.StoredProcedure);
                        
                        //return result;
                    }
                    //
                    //conn.Dispose();
                }
                
            }
            catch (Exception e)
            {
                throw new Exception("BranchMasterRepository::Insert::Error occured.", e);
            }
            return result;
        }

        public SqlConnection Connection
        {
            get
            {
                return new SqlConnection(_config.GetConnectionString("DefaultConnection"));
            }
        }
        public int SQLCommandTimeOut
        {
            get
            {

                return 120;
            }
        }
    }
}
