using MySql.Data.MySqlClient;

namespace DBtest
{
    class MySQLtest
    {
        public static string ConnectionTest()
        {
            try
            {
                string connstr = "server=115.159.101.110;port=52378;user=root;password=test; database=tlbbdb_131_20180531_main;sslmode=none";
                MySqlConnection conn = new MySqlConnection(connstr);
                conn.Open();
                string sql = "select * from t_char_1 where aid=1;";
                MySqlCommand com = new MySqlCommand(sql, conn);
                MySqlDataReader reader = com.ExecuteReader();
                
                return reader.ToString();
            }
            catch(MySqlException ex)
            {
                return ex.ToString();
            }
        }
    }
}
