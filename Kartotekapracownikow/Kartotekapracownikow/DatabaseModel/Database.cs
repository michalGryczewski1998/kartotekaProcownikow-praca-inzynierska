using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Windows;

namespace Kartotekapracownikow.DatabaseModel
{
    class Database : DbContext 
    {

        public static MySqlConnection GetMySqlConnection()
        {
            string sql = "server=localhost;uid=root;pwd=SonyW99;database=kartoteka-pracownicza";

            MySqlConnection mySqlConnection = new MySqlConnection(sql);

            try
            {
                mySqlConnection.Open();
            }
            catch(MySqlException e)
            {
                MessageBox.Show("Błąd z połączeniem do bazy danych \n" + e.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            return mySqlConnection;
        }
    }
}
