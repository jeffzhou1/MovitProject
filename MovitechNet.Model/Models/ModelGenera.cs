using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovitechNet.Model.Models
{
    public static class ModelGenera
    {
        public static void sqlSugarModelGenera(string connectionStr, string filepath, string classNameSpace)
        {

            ConnectionConfig config = new ConnectionConfig()
            {
                ConnectionString = connectionStr, //必填
                DbType = DbType.SqlServer, //必填
                IsAutoCloseConnection = true, //默认false
                InitKeyType = InitKeyType.SystemTable
            };

            using (var db = new SqlSugarClient(config))
            {
                //可以结合别名表，请看别名表的用法
                //db.SetMappingTables(mappingTableList);
                db.DbFirst.IsCreateDefaultValue().CreateClassFile(filepath, classNameSpace);
            }
        }
    }
}
