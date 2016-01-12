﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;

namespace Kupci
    {
    class Replikacija
    {
        private MySqlConnection connection;
        private MySqlDataAdapter adapter;

        public Replikacija()
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["Kupci.Properties.Settings.replikacijaConnectionString"].ConnectionString;
            connection = new MySqlConnection();
            adapter = new MySqlDataAdapter();
            connection.ConnectionString = ConnectionString;
        }

        public int ExecuteQuery(string Query, ref DataSet dataset)
        {
            connection.Open();
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
            connection.Open();
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
            connection.Open();
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
    }
}
