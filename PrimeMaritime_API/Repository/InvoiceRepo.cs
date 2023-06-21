using PrimeMaritime_API.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeMaritime_API.Repository
{
    public class InvoiceRepo
    {
        public DataSet GetBLDetails(string connstring, string BL_NO, string PORT, string ORG_CODE)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("@OPERATION", SqlDbType.VarChar, 50) { Value = "GET_BL_DETAILS" },
                new SqlParameter("@BL_NO", SqlDbType.VarChar, 100) { Value = BL_NO },
                new SqlParameter("@PORT", SqlDbType.VarChar, 100) { Value = PORT },
                new SqlParameter("@ORG_CODE", SqlDbType.VarChar, 50) { Value = ORG_CODE },
            };

            return SqlHelper.ExtecuteProcedureReturnDataSet(connstring, "SP_CRUD_INVOICE", parameters);
        }

        public static T GetSingleDataFromDataSet<T>(DataTable dataTable) where T : new()
        {
            return SqlHelper.CreateItemFromRow<T>(dataTable.Rows[0]);
        }

        public static List<T> GetListFromDataSet<T>(DataTable dataTable) where T : new()
        {
            return SqlHelper.CreateListFromTable<T>(dataTable);
        }
    }
}
