using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Allatkorhaz
{
    class DB
    {
        MySqlConnection mySqlKapcsolat;
        string server;
        string database;
        string uid;

        public MySqlConnection MySqlKapcsolat { get => mySqlKapcsolat; set => mySqlKapcsolat = value; }
        public string Server { get => server; set => server = value; }
        public string Database { get => database; set => database = value; }
        public string Uid { get => uid; set => uid = value; }

        public DB(string server, string database, string uid)
        {
            this.server = server;
            this.database = database;
            this.uid = uid;

            string kapcsolat = $"server={server};database={database};uid={uid}";

            mySqlKapcsolat = new MySqlConnection(kapcsolat);
        }
    }
}
