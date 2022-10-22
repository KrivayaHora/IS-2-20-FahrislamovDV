using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Kursovaya_Rabota
{
    static internal class ConnectionSQL   
    {
        static MySqlConnection ChucConnect = new MySqlConnection("server=10.90.12.110;port=33333;username=st_2_20_24;password=54843478;database=is_2_20_st24_KURS");
        static MySqlConnection DConnect = new MySqlConnection("server = chuc.caseum.ru; port=33333;username=st_2_20_24;password=54843478;database=is_2_20_st24_KURS");
        public static void OpenChuc()
        {
            ChucConnect.Open();
        }
        public static void CloseChuc()
        {
            ChucConnect.Close();
        }

        public static void  OpenD()
        {
            DConnect.Open();
        }

        public static void CloseD()
        {
            DConnect.Close();
        }
    }

}
