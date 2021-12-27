using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ServerApp
{
    class SQLManager
    {
        private SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-5K1J6A0;Initial Catalog=GOALRATE;Integrated Security=True");

        public bool CheckAccount(string username, string password)
        {
            string query = "select * from ACCOUNT where username = '" + username + "' and password = '" + password + "'";

            connection.Open();
   
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            connection.Close();
            if (dt.Rows.Count == 1)
            {
                return true;
            }

            return false;
        }

        public bool CheckAccountRegister(string username, string password)
        {
            string query = "insert into ACCOUNT(username,password) values(@username ,@password)";
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", password);

            try
            {
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch
            {
                connection.Close();
                return false;
            }


            return true;
        }

        public void GetJson() // Get data as json then dump into database
        {
            using (var webClient = new WebClient())
            {
                string rawJson = webClient.DownloadString(@"https://tygia.com/json.php?ran=0&rate=0&gold=1&bank=VIETCOM&date=now");

                Price listGolds = JsonConvert.DeserializeObject<Price>(rawJson);

                //Delete old formation
                deleteGoldRate();

                foreach (Gold gold in listGolds.golds[0].value)
                {
                    //Update GOLD table
                    InsertGoldRate(gold.buy, gold.sell, gold.company, gold.brand, gold.updated, gold.brand, gold.day, gold.id, gold.type, gold.code);
                    //Update HISTORY_GOLD table
                    InsertGoldRateHistory(gold.buy, gold.sell, gold.company, gold.brand, gold.updated, gold.brand, gold.day, gold.id, gold.type, gold.code);
                }
            }
            Thread.Sleep(30*60*1000); //Sleep 30 minutes
        }

        private void deleteGoldRate()
        {
            connection.Open();
            //Delete all formation
            string query = "delete from GOLD";
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch
            {
                connection.Close();
            }
        }

        private void InsertGoldRate(decimal buy, decimal sell, string company, string brand, DateTime updated, string brand1, string day, string id, string type, string code)
        {
            connection.Open();
            //Update new information from api
            string query = "insert into GOLD(buy,sell,company,brand,updated,brand1,day,id,type,code) values(@buy,@sell,@company,@brand,@updated,@brand1,@day,@id,@type,@code)";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@buy", buy);
            command.Parameters.AddWithValue("@sell", sell);
            command.Parameters.AddWithValue("@company", company);
            command.Parameters.AddWithValue("@brand", brand);
            command.Parameters.AddWithValue("@updated", updated);
            command.Parameters.AddWithValue("@brand1", brand1);
            command.Parameters.AddWithValue("@day", day);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@type", type);
            command.Parameters.AddWithValue("@code", code);

            try
            {
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch
            {
                connection.Close();
            }
        }

        private void InsertGoldRateHistory(decimal buy, decimal sell, string company, string brand, DateTime updated, string brand1, string day, string id, string type, string code)
        {
            //Delete earlier information
            string query1 = "delete from HISTORY_GOLD where day = " + day + " and id = " + id;
            connection.Open();
            SqlCommand command1 = new SqlCommand(query1, connection);
            try
            {
                command1.ExecuteNonQuery();
                connection.Close();
            }
            catch
            {
                connection.Close();
            }

            //Insert latest information
            string query2 = "insert into HISTORY_GOLD(buy,sell,company,brand,updated,brand1,day,id,type,code) values(@buy,@sell,@company,@brand,@updated,@brand1,@day,@id,@type,@code)";
            connection.Open();
            SqlCommand command2 = new SqlCommand(query2, connection);
            command2.Parameters.AddWithValue("@buy", buy);
            command2.Parameters.AddWithValue("@sell", sell);
            command2.Parameters.AddWithValue("@company", company);
            command2.Parameters.AddWithValue("@brand", brand);
            command2.Parameters.AddWithValue("@updated", updated);
            command2.Parameters.AddWithValue("@brand1", brand1);
            command2.Parameters.AddWithValue("@day", day);
            command2.Parameters.AddWithValue("@id", id);
            command2.Parameters.AddWithValue("@type", type);
            command2.Parameters.AddWithValue("@code", code);

            try
            {
                command2.ExecuteNonQuery();
                connection.Close();
            }
            catch
            {
                connection.Close();
            }
        }

        public DataTable GetDataTable()
        {
            connection.Open();
            string query = "select * from GOLD";

            SqlDataAdapter ada = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            connection.Close();

            return dt;
        }

        public DataTable GetDataTable_Date(string date)
        {
            connection.Open();
            string query = "select * from HISTORY_GOLD where day = " + date;

            SqlDataAdapter ada = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            connection.Close();

            return dt;
        }

        public DataTable GetDataTable_Type(string type)
        {
            connection.Open();
            string query = "select * from HISTORY_GOLD where type = '" + type + "'";

            SqlDataAdapter ada = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            connection.Close();

            return dt;
        }
        public DataTable GetDataTableDate_Type(string date, string type)
        {
            connection.Open();
            string query = "select * from HISTORY_GOLD where day = " + date + " and type = '" + type + "'";

            SqlDataAdapter ada = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            connection.Close();

            return dt;
        }

        public string getGoldType()
        {
            string ans = "";
            //Ket noi database
            connection.Open();
            // Tạo đối tượng SqlCommand
            var command = new SqlCommand();
            command.Connection = connection;

            // Câu truy vấn lấy danh mục
            string queryString = @"SELECT distinct type FROM HISTORY_GOLD order by type asc";
            command.CommandText = queryString;

            // Thi hành truy vấn trả về SqlReader
            var reader = command.ExecuteReader();

            // Kiểm tra có kết quả trả về
            if (reader.HasRows)
            {
                // Đọc từng dòng tập kết quả: ans = 7,--All--,type1,type2,...,typeN
                while (reader.Read())
                {
                    string type = reader["type"].ToString();
                    ans += ',';
                    ans += type;                    
                }
            }
            connection.Close();
            return ans;
        }

        public void UpdateGold(decimal buy, decimal sell, string company, string brand, DateTime updated, string brand1, string day, string id, string type, string code)
        {
            connection.Open();
            string query = "exec UPDATEGOLD @buy,@sell,@company,@brand,@updated,@brand1,@day,@id,@type,@code";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@buy", buy);
            command.Parameters.AddWithValue("@sell", sell);
            command.Parameters.AddWithValue("@company", company);
            command.Parameters.AddWithValue("@brand", brand);
            command.Parameters.AddWithValue("@updated", updated);
            command.Parameters.AddWithValue("@brand1", brand1);
            command.Parameters.AddWithValue("@day", day);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@type", type);
            command.Parameters.AddWithValue("@code", code);

            try
            {
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch
            {

                connection.Close();
            }
        }

        /*public void UpdateJson(string now)
        {
            Delete(now);

            using (var webClient = new WebClient())
            {
                string rawJson = webClient.DownloadString(@"https://tygia.com/json.php?ran=0&rate=0&gold=1&bank=VIETCOM&date=now");

                Price listGolds = JsonConvert.DeserializeObject<Price>(rawJson);

                foreach (Gold gold in listGolds.golds[0].value)
                {
                    UpdateGold(gold.buy, gold.sell, gold.company, gold.brand, gold.updated, gold.brand, gold.day, gold.id, gold.type, gold.code);
                }
            }
        }
        private void Delete(string now)
        {
            connection.Open();
            string query = "delete from GOLD where CONVERT(VARCHAR(10), updated, 103) =  @now";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@now", now);
            try
            {
                command.ExecuteNonQuery();
            }
            catch
            {
                connection.Close();
            }
            connection.Close();
        }*/
    }
}
