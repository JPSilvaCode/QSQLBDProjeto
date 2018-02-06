using QSQLBDProjeto.Aplicacao;
using QSQLBDProjeto.Dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexaoBD
{
    class Program
    {
        static void Main(string[] args)
        {
            //SqlConnection connection = new SqlConnection(@"Data Source=0.0.0.0,1433;Initial Catalog=ExemploBD;User ID=sa;Password=000000");
            //connection.Open();

            //string strQueryUpdate = "UPDATE USUARIOS SET NOME = 'LUIZ' WHERE USUARIOID = 3";
            //SqlCommand commandUpdate = new SqlCommand(strQueryUpdate, connection);
            //commandUpdate.ExecuteNonQuery();

            //string strQueryDelete = "DELETE FROM USUARIOS WHERE USUARIOID = 3";
            //SqlCommand commandDelete = new SqlCommand(strQueryDelete, connection);
            //commandDelete.ExecuteNonQuery();

            //string strQueryInsert = "INSERT INTO USUARIOS (NOME,CARGO,DATE) VALUES ('THIAO','GERENTE','01-01-2011')";
            //SqlCommand commandInsert = new SqlCommand(strQueryInsert, connection);
            //commandInsert.ExecuteNonQuery();

            //string strQuerySelect = "SELECT * FROM USUARIOS";
            //SqlCommand commandSelect = new SqlCommand(strQuerySelect, connection);
            //SqlDataReader reader = commandSelect.ExecuteReader();

            //var db = new BD();

            //string strQueryInsert = "INSERT INTO USUARIOS (NOME,CARGO,DATE) VALUES ('LUCIO','COORDENADOR','01-01-2011')";
            //db.ExecutaComando(strQueryInsert);

            //Console.Write("Digite o nome do usuário: ");
            //string nome = Console.ReadLine();

            //Console.Write("Digite o cargo do usuário: ");
            //string cargo = Console.ReadLine();

            //Console.Write("Digite a data de cadastro: ");
            //string data = Console.ReadLine();

            //var usuarios = new Usuarios
            //{
            //    UsuarioId = 6,
            //    Nome = nome,
            //    Cargo = cargo,
            //    Date = DateTime.Parse(data)
            //};

            //var usuarioAplicacao = new UsuarioAplicacao();
            //usuarioAplicacao.Salvar(usuarios);

            //string strQuerySelect = "SELECT * FROM USUARIOS";
            //List<Usuarios> usuariosList = usuarioAplicacao.ListarTodos();

            //foreach (Usuarios usuarios in usuariosList)
            //{
            //    Console.WriteLine("Id: {0}, Nome: {1}, Cargo: {2}, Data: {3}", usuarios.Id, usuarios.Nome, usuarios.Cargo, usuarios.Data);
            //}

            //while (reader.Read())
            //{
            //    Console.WriteLine("Id: {0}, Nome: {1}, Cargo: {2}, Data: {3}", reader["USUARIOID"], reader["NOME"], reader["CARGO"], reader["DATE"]);
            //}

            Console.ReadKey();
        }
    }
}
