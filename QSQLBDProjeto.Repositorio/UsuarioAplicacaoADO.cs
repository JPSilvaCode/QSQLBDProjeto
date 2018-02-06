using QSQLBDProjeto.Dominio;
using QSQLBDProjeto.Dominio.contrato;
using QSQLBDProjeto.Repositorio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace QSQLBDProjeto.RepositorioADO
{
    public class UsuarioAplicacaoADO : IRepositorio<Usuarios>
    {
        private BD bd;

        private void Inserir(Usuarios usuarios)
        {
            var strQuery = "";
            strQuery += "INSERT INTO USUARIOS (NOME,CARGO,DATA)";
            strQuery += String.Format(" VALUES ('{0}','{1}','{2}')", usuarios.Nome, usuarios.Cargo, usuarios.Data);

            using (bd = new BD())
            {
                bd.ExecutaComando(strQuery);
            }
        }

        private void Alterar(Usuarios usuarios)
        {
            var strQuery = "";
            strQuery += "UPDATE USUARIOS SET";
            strQuery += String.Format(" NOME = '{0}',CARGO = '{1}',DATA = '{2}' WHERE ID = '{3}'", usuarios.Nome, usuarios.Cargo, usuarios.Data, usuarios.Id);

            using (bd = new BD())
            {
                bd.ExecutaComando(strQuery);
            }
        }

        public void Salvar(Usuarios usuarios)
        {
            if (usuarios.Id.Equals(0))
                Inserir(usuarios);
            else
                Alterar(usuarios);
        }

        public void Excluir(Usuarios usuarios)
        {
            var strQuery = "";
            strQuery += "DELETE FROM USUARIOS";
            strQuery += String.Format(" WHERE ID = '{0}'", usuarios.Id);

            using (bd = new BD())
            {
                bd.ExecutaComando(strQuery);
            }
        }

        public IEnumerable<Usuarios> ListarTodos()
        {
            bd = new BD();
            string strQuery = "SELECT * FROM USUARIOS";
            var retorno = bd.ExecutaComandoComRetorno(strQuery);

            return ReaderEmLista(retorno);
        }

        public Usuarios ListarPorId(string id)
        {
            bd = new BD();
            string strQuery = String.Format("SELECT * FROM USUARIOS WHERE ID = {0}", id);
            var retorno = bd.ExecutaComandoComRetorno(strQuery);

            return ReaderEmLista(retorno).FirstOrDefault();
        }

        private List<Usuarios> ReaderEmLista(SqlDataReader reader)
        {
            var usuarios = new List<Usuarios>();
            while (reader.Read())
            {
                var tempoObjeto = new Usuarios()
                {
                    Id = int.Parse(reader["ID"].ToString()),
                    Nome = reader["NOME"].ToString(),
                    Cargo = reader["CARGO"].ToString(),
                    Data = DateTime.Parse(reader["DATA"].ToString())
                };

                usuarios.Add(tempoObjeto);
            }

            reader.Close();
            return usuarios;
        }
    }
}
