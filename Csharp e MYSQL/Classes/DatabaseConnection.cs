using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace Csharp_e_MYSQL.Classes
{
    class DatabaseConnection
    {
        private string dbhost, dbnome, dbuser, dbpass;
        private int dbport;
        private MySqlConnection connection;
        private MySqlCommand command;

        public string Dbhost { get => dbhost; set => dbhost = value; }
        public string Dbnome { get => dbnome; set => dbnome = value; }
        public string Dbuser { get => dbuser; set => dbuser = value; }
        public string Dbpass { get => dbpass; set => dbpass = value; }
        public int Dbport { get => dbport; set => dbport = value; }

        public void Connect()  //ABRE CONEXÃO COM O BANCO DE DADOS
        {
            string ConString = $"server={dbhost};database={dbnome};uid={dbuser};pwd={dbpass};port={dbport}";
            try
            {
                connection = new MySqlConnection(ConString);
                command = connection.CreateCommand();
                connection.Open();
            }
            catch(Exception e)
            {
                MessageBox.Show("Falha ao conectar-se com o banco de dados! \n\n" + e, "Abrir Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Close()  //FECHA A CONEXÃO COM O BANCO DE DADOS DEFINIDO PELA CLASSE
        {
            try
            {
                connection.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show("Falha ao fechar conexão com o banco de dados! \n\n" + e, "Fechar Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void NonQuery(string sql)
        {
            command.CommandText = sql;
            command.ExecuteNonQuery();
        }

        public MySqlDataReader Query(string sql)
        {
            command.CommandText = sql;
            return command.ExecuteReader();
        }

        public DataTable FillDataTable(string sql, string operacao)
        {
            DataTable dt = new DataTable();
            MySqlDataReader MySqlDr;
            try
            {
                MySqlDr = Query(sql);
                dt.Load(MySqlDr);
                MySqlDr.Close();
                Close();
                return dt;
            }
            catch(Exception e)
            {
                dt = null;
                MessageBox.Show($"Falha ao tentar {operacao}! \n\n" + e, $"{operacao}", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return dt;
            }
        }
    }
}
