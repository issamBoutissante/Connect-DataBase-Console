using System;
using System.Data.SqlClient;
using System.Configuration;

namespace ConnectToDataBase
{
    class Program
    {
        static readonly string mon_dataBase = ConfigurationManager.ConnectionStrings["monDataBase"].ConnectionString;
        static void Main(string[] args)
        {
            SqlConnection mon_connection = new SqlConnection(mon_dataBase);
            using (mon_connection)
            {
                mon_connection.Open();
                Console.WriteLine("la connection est : " + mon_connection.State);
            }
            Console.WriteLine("la connection est : " + mon_connection.State);
            Console.ReadKey();
        }
    }
}
