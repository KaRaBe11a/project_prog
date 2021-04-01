using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Project.WorkWithSql
{
    class Test
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=test");

        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }

        }
        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public MySqlConnection getConnection()
        {
            return connection;
        }

        public static List<Classes.Request> DownloadRequests()
        {
            List<Classes.Request> requests = new List<Classes.Request>();
            Test dataBase = new Test();
            List<string> str = new List<string>();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `requests`", dataBase.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            for(int i = 0; i<table.Rows.Count; i++)
            {
                for (int j = 0; j<table.Columns.Count; j++)
                {
                    str.Add(table.Rows[i][j].ToString());
                }
                requests.Add(new Classes.Request(Convert.ToInt32(str[0]), Convert.ToInt32(str[1]), Convert.ToInt32(str[2]), Convert.ToInt32(str[3])));
                str.Clear();
            }
            return requests;

        }

        public static void AllowRequests(Classes.Request request)
        {
            Test dataBase = new Test();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `sklad` WHERE `Articule` = @aR", dataBase.getConnection());
            dataBase.connection.Open();
            command.Parameters.Add("@aR", MySqlDbType.Int32).Value = request.articule;
            int countInSklad;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            countInSklad = Convert.ToInt32(table.Rows[0][1]);

            command = new MySqlCommand("UPDATE `sklad` SET `Count` = @cO WHERE `Articule` = @aR", dataBase.getConnection());
            command.Parameters.Add("@cO", MySqlDbType.Int32).Value = countInSklad - request.count;
            command.Parameters.Add("@aR", MySqlDbType.Int32).Value = request.articule;
            command.ExecuteNonQuery();

            command = new MySqlCommand("INSERT INTO `transit`(`MagId`, `Articule`, `Count`, `reqId`) VALUES (@mI, @aR, @cO, @rI)", dataBase.getConnection());
            command.Parameters.Add("@mI", MySqlDbType.Int32).Value = request.magId;
            command.Parameters.Add("@aR", MySqlDbType.Int32).Value = request.articule;
            command.Parameters.Add("@cO", MySqlDbType.Int32).Value = request.count;
            command.Parameters.Add("@rI", MySqlDbType.Int32).Value = request.reqId;
            command.ExecuteNonQuery();

            command = new MySqlCommand("DELETE FROM `requests` WHERE `reqId` = @rI", dataBase.getConnection());
            command.Parameters.Add("rI", MySqlDbType.Int32).Value = request.reqId;
            command.ExecuteNonQuery();
            dataBase.connection.Close();
            MessageBox.Show("Complite");





        }


    }
}
