using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System.Data.Common;

namespace IBTProcessor
{
    class DataAccessLayer
    {
        public static void InsertIBTData(string storedProcName, String eventType, String timestamp)
        {
            Database objDatabase = DatabaseFactory.CreateDatabase("IBTDatabase");
            using (DbCommand sprocCmd = objDatabase.GetStoredProcCommand(storedProcName))
            {
                objDatabase.AddInParameter(sprocCmd, "eventtype", System.Data.DbType.String, eventType);
                objDatabase.AddInParameter(sprocCmd, "timestamp", System.Data.DbType.String, timestamp);
                objDatabase.ExecuteScalar(sprocCmd);
            }     
        }
    }
}
