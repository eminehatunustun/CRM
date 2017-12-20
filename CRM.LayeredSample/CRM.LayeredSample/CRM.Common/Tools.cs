using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Common
{
    using System.Data.SqlClient;
    public class Tools
    {
        public static string ConnectionString
        {
            get
            {
                return @"Server = DESKTOP-2847M88\MSSQLSERVER01; Database = CrmDB; UID=eminehatunustun; PWD=1234";
            }
        }
    }
}
