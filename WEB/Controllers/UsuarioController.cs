using QSQLBDProjeto.Aplicacao;
using QSQLBDProjeto.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WEB.Controllers
{
    public class UsuarioController : Controller
    {
        private UsuarioAplicacao appUsuario;

        public UsuarioController()
        {
            appUsuario = UsuarioAplicacaoConstrutor.UsuarioApEF();
        }

        // GET: Usuario
        public ActionResult Index()
        {
            //var appUsuario = UsuarioAplicacaoConstrutor.UsuarioApADO();
            var listaUsuarios = appUsuario.ListarTodos();

            return View(listaUsuarios);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Usuarios usuario)
        {
            if (ModelState.IsValid)
            {
                //var appUsuario = UsuarioAplicacaoConstrutor.UsuarioApADO();
                appUsuario.Salvar(usuario);

                return RedirectToAction("Index");
            }

            return View(usuario);
        }

        public ActionResult Editar(string id)
        {
            //var appUsuario = UsuarioAplicacaoConstrutor.UsuarioApADO();
            var usuario = appUsuario.ListarPorId(id);

            if (usuario == null)
                return HttpNotFound();

            return View(usuario);
        }

        [HttpPost]
        public ActionResult Editar(Usuarios usuario)
        {
            if (ModelState.IsValid)
            {
                //var appUsuario = UsuarioAplicacaoConstrutor.UsuarioApADO();
                appUsuario.Salvar(usuario);

                return RedirectToAction("Index");
            }

            return View(usuario);
        }

        public ActionResult Details(string id)
        {
            //var appUsuario = UsuarioAplicacaoConstrutor.UsuarioApADO();
            var usuario = appUsuario.ListarPorId(id);

            if (usuario == null)
                return HttpNotFound();

            return View(usuario);
        }

        public ActionResult Delete(string id)
        {
            //var appUsuario = UsuarioAplicacaoConstrutor.UsuarioApADO();
            var usuario = appUsuario.ListarPorId(id);

            if (usuario == null)
                return HttpNotFound();

            return View(usuario);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirm(string id)
        {
            //var appUsuario = UsuarioAplicacaoConstrutor.UsuarioApADO();
            var usuario = appUsuario.ListarPorId(id);
            appUsuario.Excluir(usuario);

            return RedirectToAction("Index");
        }
    }
}