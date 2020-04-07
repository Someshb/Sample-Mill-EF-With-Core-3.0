using DataAccess.DBEntities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Dapper;

namespace DataAccess
{
    public class PropertyInfo : IPropertyInfo
    {
       
        private string _connectionString;

        public PropertyInfo()
        {
            _connectionString = "Data Source=srv1658;Initial Catalog=JumboRolls;"
            + "Integrated Security=true"; 
          
        }
        public IEnumerable<PropertyInfoEntity> GetAllStudent()
        {
            var Query = new StringBuilder();
            try
            {
                //var result = _db.Query<PropertyInfoEntity>(sQuery);
                //Query.Append(" INTO MM_BranchMaster (BRANCHCODE,BRANCHNAME,ADDUSERID,ADDDATETIME,FREEZEFLAG) values ('" + entity.branchcode + "','" + entity.branchname + "','" + entity.adduserid + "',getdate(),'N')");
                //_db.Query<string>(Query.ToString()).ToString();
                //return true;

                using (SqlConnection conn = Connection)
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                        string sQuery = "sp_Test_getJumboRolls_Physical_Properties";
                        DynamicParameters parameter = new DynamicParameters();

                        //parameter.Add("@PM", "PM1", DbType.String, ParameterDirection.Input);
                        //parameter.Add("@StartDate", "2020-03-13 07:00:00.000", DbType.String, ParameterDirection.Input);
                        //parameter.Add("@EndDate", "2020-03-14 08:00:00.000", DbType.String, ParameterDirection.Input);
                        //parameter.Add("@Grade", "ALL GRADES", DbType.String, ParameterDirection.Input);
                        //parameter.Add("@Label", "ANY LABEL", DbType.String, ParameterDirection.Input);
                        //parameter.Add("@RejectCauseID", 0, DbType.Int32, ParameterDirection.Input);

                        var result = conn.Query<PropertyInfoEntity>(sQuery, parameter, null, false, 120, CommandType.StoredProcedure);
                        //var result = await conn.ExecuteScalarAsync<IEnumerable<CustomerEntity>>(sQuery, param : parameter ,null,commandTimeout: SQLCommandTimeOut);
                        return result;
                    }
                    //
                    conn.Dispose();
                }
                return null;
            }
            catch (Exception e)
            {
                throw new Exception("BranchMasterRepository::Insert::Error occured.", e);
            }
        }

        public PropertyInfoEntity GetAllStudentById(int Id)
        {
            throw new NotImplementedException();
        }

        public SqlConnection Connection
        {
            get
            {
                return new SqlConnection(_connectionString);
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
