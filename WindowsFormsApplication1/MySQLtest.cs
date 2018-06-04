using MySql.Data.MySqlClient;
using System;
using System.Text;
namespace DBtest
{
    class MySQLtest
    {
        public static string ConnectionTest()
        {
            string connstr = "server=115.159.101.110;port=5237;user=root;password=test; database=tlbbdb_131_20180531_main;sslmode=none";
            MySqlConnection conn = new MySqlConnection(connstr);
            string resultstr = null;
            try
            {
                conn.Open();
                string sql = "select * from t_char_1 where aid=1;";
                MySqlCommand com = new MySqlCommand(sql, conn);
                MySqlDataReader reader = com.ExecuteReader();
                //string accname_result = reader.GetString("accname");
                //string accname_result1 = reader.GetString(3);
                //conn.Close();

                resultstr = "OK " + conn.State;
                conn.Close();
                resultstr = resultstr + " " + conn.State;
                return resultstr;
            }
            catch (MySqlException ex)
            {
                conn.Open();
                resultstr = "Error no=" + ex.Number.ToString();
                return resultstr;
            }
        }
        public static int GetMDResult(string GUIDH,string GUIDL,string MDstr)
        {
            int MD = Convert.ToInt32(MDstr);
            //int MDStrLength = 8;
            string TableName = null;
            string ColumnName = null;
            int StartNum = 0;
            if (MD < 0 || MD>1261) { return -1; }
            if (MD >= 0 && MD<=511)
            {
                TableName = "t_char_2";
                ColumnName = "mdata";
                StartNum = (MD - 512) % 30 * 8 + 1; //MD在对应MD BLOCK的起始位置
            }
            if (MD >= 512 && MD <= 1141)
            {
                TableName = "t_charextra";
                int mdblkCount = (MD - 512) / 30+1; 
                StartNum = (MD - 512) % 30*8 + 1; //MD在对应MD BLOCK的起始位置
                ColumnName = "mdblk" + mdblkCount.ToString();
            }
            if (MD >= 1142 && MD <= 1261)
            {
                TableName = "t_missiondata";
                int mdblkCount = (MD - 1142) / 30 + 1;
                StartNum = (MD - 1142) % 30*8 + 1; //MD在对应MD BLOCK的起始位置
                ColumnName = "mdblk" + mdblkCount.ToString();
            }
            string QueryCommand = "select substr(" + ColumnName + "," + StartNum.ToString() + ",8) from " + TableName + " where charguidh=" + GUIDH + " and charguidl=" + GUIDL + ";";
            
            return 1;
        }
    }
}
