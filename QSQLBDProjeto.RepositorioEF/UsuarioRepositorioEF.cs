using QSQLBDProjeto.Dominio;
using QSQLBDProjeto.Dominio.contrato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QSQLBDProjeto.RepositorioEF
{
    public class UsuarioRepositorioEF : IRepositorio<Usuarios>
    {
        private readonly BD bd;

        public UsuarioRepositorioEF()
        {
            bd = new BD();
        }

        public void Excluir(Usuarios entidade)
        {
            var usuarioExcluir = bd.Usuario.First(x => x.Id == entidade.Id);
            bd.Set<Usuarios>().Remove(usuarioExcluir);
            bd.SaveChanges();
        }

        public Usuarios ListarPorId(string id)
        {
            int idInt;
            Int32.TryParse(id, out idInt);
            return bd.Usuario.First(x => x.Id == idInt);
        }

        public IEnumerable<Usuarios> ListarTodos()
        {
            return bd.Usuario;
        }

        public void Salvar(Usuarios entidade)
        {
            if (entidade.Id.Equals(0))
            {
                bd.Usuario.Add(entidade);
            }
            else
            {
                var usuarioAlterar = bd.Usuario.First(x => x.Id == entidade.Id);
                usuarioAlterar.Nome = entidade.Nome;
                usuarioAlterar.Cargo = entidade.Cargo;
                usuarioAlterar.Data = entidade.Data;
            }

            bd.SaveChanges();
        }
    }
}
