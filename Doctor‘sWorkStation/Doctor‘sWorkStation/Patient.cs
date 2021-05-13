using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Doctor_sWorkStation
{
    class Patient
    {
        public static string No;
        public static string Name;
        public static string ThisNo;//住院号

        public static void ConnectDataBase()
        {
            SqlConnection sqlConnection = new SqlConnection();                                          //声明并实例化SQL连接；
            sqlConnection.ConnectionString =
                    "Server=(local);Database=DataBase_DoctorWorkStation;Integrated Security=true";
        }
    }
    
}
