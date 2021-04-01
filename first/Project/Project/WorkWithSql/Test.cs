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

        public static List<Classes.Magazine> DownloadMagazines()
        {
            List<Classes.Magazine> magazines = new List<Classes.Magazine>();
            Test dataBase = new Test();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `magazines`", dataBase.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            List<string> str = new List<string>();
            for (int i = 0; i<table.Rows.Count; i++)
            {
                for(int j = 0; j<table.Columns.Count; j++)
                {
                    str.Add(table.Rows[i][j].ToString());
                }
                magazines.Add(new Classes.Magazine(str[0], Convert.ToInt32(str[1])));
                str.Clear();
            }
            return magazines;
        }

        public static List<Classes.Prod> DownloadProdFromMagazine(int magId)
        {
            List<Classes.Prod> prod = new List<Classes.Prod>();
            Test dataBase = new Test();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `productsinmagazines` WHERE `MagId` = @mI", dataBase.getConnection());
            command.Parameters.Add("@mI", MySqlDbType.Int32).Value = magId;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            List<string> str = new List<string>();
            for (int i = 0; i<table.Rows.Count; i++)
            {
                for(int j = 0; j<table.Columns.Count; j++)
                {
                    str.Add(table.Rows[i][j].ToString());
                }
                prod.Add(new Classes.Prod(Convert.ToInt32(str[1]), Convert.ToInt32(str[2])));
                str.Clear();
            }

            return prod;
        }

        public static Classes.Product ConvertProdInProduct(int art)
        {
            Test dataBase = new Test();
            Classes.Product product;
            MySqlCommand command = new MySqlCommand("SELECT * FROM `products` WHERE `Articule` = @aR", dataBase.getConnection());
            command.Parameters.Add("@aR", MySqlDbType.Int32).Value = art;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            List<string> str = new List<string>();
            for (int i = 0; i<table.Rows.Count; i++)
            {
                for (int j = 0; j<table.Columns.Count; j++)
                {
                    str.Add(table.Rows[i][j].ToString());
                }
                product = new Classes.Product(str[0], Convert.ToInt32(str[1]), Convert.ToInt32(str[2]));
                return product;
            }
            product = new Classes.Product("ERROR", -1, -1);
            return product;

        }
        public static List<Classes.Product> DownloadProducts()
        {
            List<Classes.Product> products = new List<Classes.Product>();
            List<string> str = new List<string>();

            Test dataBase = new Test();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `products`", dataBase.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            for (int i = 0; i<table.Rows.Count; i++)
            {
                for (int j = 0; j<table.Columns.Count; j++)
                {
                    str.Add(table.Rows[i][j].ToString());
                }
                products.Add(new Classes.Product(str[0], Convert.ToInt32(str[1]), Convert.ToInt32(str[2])));
                str.Clear();
            }
            return products;

        }

        public static void MakeRequest(int magId,int prodArt, int count)
        {
            Test dataBase = new Test();
            MySqlCommand command = new MySqlCommand("INSERT INTO `requests`(`MagId`, `Articule`, `Count`) VALUES (@mI, @aR, @cO)", dataBase.getConnection());
            command.Parameters.Add("@mI", MySqlDbType.Int32).Value = magId;
            command.Parameters.Add("@aR", MySqlDbType.Int32).Value = prodArt;
            command.Parameters.Add("@cO", MySqlDbType.Int32).Value = count;
            dataBase.openConnection();
            command.ExecuteNonQuery();
            dataBase.closeConnection();
        }

        public static List<Classes.Request> DownloadTransits(int magId)
        {
            List<Classes.Request> requests = new List<Classes.Request>();
            List<string> str = new List<string>();

            Test dataBase = new Test();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `transit` WHERE `MagId` = @mI", dataBase.getConnection());
            command.Parameters.Add("@mI", MySqlDbType.Int32).Value = magId;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);

            for(int i = 0; i<table.Rows.Count; i++)
            {
                for(int j = 0; j<table.Columns.Count; j++)
                {
                    str.Add(table.Rows[i][j].ToString());
                }
                requests.Add(new Classes.Request(Convert.ToInt32(str[0]), Convert.ToInt32(str[1]), Convert.ToInt32(str[2]), Convert.ToInt32(str[3])));
                str.Clear();
            }
            return requests;
        }

        public static void ReceaveTransit(Classes.Request request)
        {
            List<string> str = new List<string>();
            Test dataBase = new Test();
            MySqlCommand command = new MySqlCommand("DELETE FROM `transit` WHERE `reqId` = @rI", dataBase.getConnection());
            command.Parameters.Add("@rI", MySqlDbType.Int32).Value = request.reqId;
            dataBase.openConnection();
            command.ExecuteNonQuery();
            dataBase.closeConnection();

            command = new MySqlCommand("SELECT * FROM `productsinmagazines` WHERE `MagId` = @mI AND `Articule` = @aR", dataBase.getConnection());
            command.Parameters.Clear();
            command.Parameters.Add("@mI", MySqlDbType.Int32).Value = request.magId;
            command.Parameters.Add("@aR", MySqlDbType.Int32).Value = request.articule;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            for(int i = 0; i<table.Rows.Count; i++)
            {
                for(int j = 0; j<table.Columns.Count; j++)
                {
                    str.Add(table.Rows[i][j].ToString());
                }
                request.count = request.count + Convert.ToInt32(str[2]);
                str.Clear();
            }


            command = new MySqlCommand("UPDATE `productsinmagazines` SET `Count` = @cO WHERE `MagId` = @mI AND `Articule` = @aR", dataBase.getConnection());
            command.Parameters.Clear();
            command.Parameters.Add("@mI", MySqlDbType.Int32).Value = request.magId;
            command.Parameters.Add("@aR", MySqlDbType.Int32).Value = request.articule;
            command.Parameters.Add("@cO", MySqlDbType.Int32).Value = request.count;
            dataBase.openConnection();
            command.ExecuteNonQuery();
            dataBase.closeConnection();
        }

    }
}
