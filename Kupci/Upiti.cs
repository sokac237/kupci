using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;

namespace Kupci
    {
    class Upiti
    {
        private MySqlConnection connection;
        private MySqlDataAdapter adapter;
        private MySqlTransaction trans;

        public Upiti()
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["Kupci.Properties.Settings.mpmanConnectionString"].ConnectionString;
            connection = new MySqlConnection();
            adapter = new MySqlDataAdapter();
            connection.ConnectionString = ConnectionString;
        }

        public int ExecuteQuery(string Query, ref DataSet dataset)
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            MySqlCommand command = new MySqlCommand(Query);
            command.Connection = this.connection;
            int res = command.ExecuteNonQuery();
            adapter.SelectCommand = command;
            dataset.Clear();
            adapter.Fill(dataset);
            connection.Close();
            return res;
        }
        public int ExecuteQuery(string Query, ref DataTable datatable)
        {
            connection.Close();
            connection.Open();
            MySqlCommand command = new MySqlCommand(Query);
            command.Connection = this.connection;
            int res = command.ExecuteNonQuery();
            adapter.SelectCommand = command;
            datatable.Clear();
            adapter.Fill(datatable);
            connection.Close();
            return res;
        }
        public string ExecuteQuery(string Query)
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            MySqlCommand command = new MySqlCommand(Query);
            command.Connection = this.connection;
            String res = "";
            if (command.ExecuteScalar() != null) res = command.ExecuteScalar().ToString();
            connection.Close();
            if (res == "") res = "-1";
            return res;
        }
        public int Operacija(string Query)
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            MySqlCommand command = new MySqlCommand(Query);
            command.Connection = this.connection;

            int res = command.ExecuteNonQuery();
            adapter.SelectCommand = command;
            connection.Close();
            return res;

        }

        public void ZatvoriKonekciju()
        {
            connection.Close();
        }

        public void PocniTransakciju()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            MySqlCommand command = connection.CreateCommand();
            
            trans = connection.BeginTransaction();
            command.Connection = connection;
            command.Transaction = trans;
        }

        public void ZavrsiTransakciju()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            trans.Commit();
        }

        public void VratiTransakciju()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            trans.Rollback();
        }
    }
}
