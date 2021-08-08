using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

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

        public void Close()
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

    }
}
