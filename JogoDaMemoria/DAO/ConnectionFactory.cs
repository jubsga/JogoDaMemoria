using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaMemoria.DAO
{
    class ConnectionFactory
    {
        public static MySqlConnection Create()
        {
            string connectionString = "Server=localhost;Database=JogoDaMemoria;Uid=root;Pwd=root;";
            return new MySqlConnection(connectionString);
        }
    }
}
