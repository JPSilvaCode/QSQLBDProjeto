using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QSQLBDProjeto.Repositorio
{
    public class BD : IDisposable
    {
        private readonly SqlConnection connection = null;

        public BD()
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["conexaoBD"].ConnectionString);
            connection.Open();
        }

        public void ExecutaComando(string strQuery)
        {
            var command = new SqlCommand
            {
                CommandText = strQuery,
                CommandType = CommandType.Text,
                Connection = connection
            };
            command.ExecuteNonQuery();
        }

        public SqlDataReader ExecutaComandoComRetorno(string strQuery)
        {
            var command = new SqlCommand(strQuery, connection);
            return command.ExecuteReader();
        }

        public void Dispose()
        {
            if (connection.State == ConnectionState.Open)
                connection.Close();
        }
    }
}
