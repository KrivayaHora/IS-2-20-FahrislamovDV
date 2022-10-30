using MySql.Data.MySqlClient;
using SqlKata.Compilers;
using SqlKata.Execution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovaya_Rabota
{
    class DBFGrid
    {  
        static MySqlConnection ConnectStaff = null;

        public static MySqlConnection GetConnection()
        {
            if (ConnectStaff == null)
            {
                ConnectStaff = new MySqlConnection("server=chuc.caseum.ru;port=33333;username=st_2_20_24;password=54843478;database=is_2_20_st24_KURS");
            }
            return ConnectStaff;
        }
        public static QueryFactory DB = null;
        public static QueryFactory DataBase()
        {
            if (DB == null)
            {
                var Compiler = new MySqlCompiler();

                DB = new QueryFactory(GetConnection(), Compiler);
            }
            return DB;
        }
    }
}
