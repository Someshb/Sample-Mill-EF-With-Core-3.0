using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Dapper;
using DataAccess.DBEntities;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;

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
                
                using (MySqlConnection conn = Connection)
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                        //string sQuery = "GetStudentByID";
                        string sQuery = "Select * From student";
                        DynamicParameters parameter = new DynamicParameters();
                                              

                        parameter.Add("@Param1", "", DbType.String, ParameterDirection.Input);
                        parameter.Add("@Param2", "", DbType.String, ParameterDirection.Input);
                        parameter.Add("@Param3", "", dbType: DbType.String, direction: ParameterDirection.Input);

                        result = conn.Query<StudentEntity>(sQuery,
                          // parameter,
                            commandType: CommandType.Text);

                        //return result;
                    }
                    //
                    //conn.Dispose();
                }

                /// DO the other processing and logic for ScholerShip 


                
            }
            catch (Exception e)
            {
                throw new Exception("BranchMasterRepository::Insert::Error occured.", e);
            }
            return result;
        }

        public MySqlConnection Connection
        {
            get
            {
                //For Connection to Sql Server ---- Un Comments the followig line 
                //  return new SqlConnection(_config.GetConnectionString ("DefaultConnection"));
                // For Connection to MySQL  ---- Un Comments the followig line 
                 
                return new MySqlConnection(_config.GetConnectionString("DefaultConnection"));
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
