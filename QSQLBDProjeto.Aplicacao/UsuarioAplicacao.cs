using QSQLBDProjeto.Dominio;
using QSQLBDProjeto.Dominio.contrato;
using QSQLBDProjeto.RepositorioADO;
using System.Collections.Generic;

namespace QSQLBDProjeto.Aplicacao
{
    public class UsuarioAplicacao
    {
        private readonly IRepositorio<Usuarios> usuarioAplicacaoADO;

        public UsuarioAplicacao(IRepositorio<Usuarios> repositorio)
        {
            usuarioAplicacaoADO = repositorio;
        }

        public void Salvar(Usuarios usuarios)
        {
            usuarioAplicacaoADO.Salvar(usuarios);
        }

        public void Excluir(Usuarios usuarios)
        {
            usuarioAplicacaoADO.Excluir(usuarios);
        }

        public IEnumerable<Usuarios> ListarTodos()
        {
            return usuarioAplicacaoADO.ListarTodos();
        }

        public Usuarios ListarPorId(string id)
        {
            return usuarioAplicacaoADO.ListarPorId(id);
        }
    }
}
