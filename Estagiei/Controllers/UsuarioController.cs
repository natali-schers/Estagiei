using Estagiei.Models;
using Estagiei.Repositories;
using Estagiei.Services;
using EstagieiConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Estagiei.Controllers
{
    public class UsuarioController : Controller
    {
        #region Dependências
        private IUsuarioService _usuarioService;

        public UsuarioController()
        {
            _usuarioService = new UsuarioService();
        }
        #endregion Dependências

        [HttpGet]
        public ActionResult Index()
        {
            List<Usuario> usuarios;

            try
            {
                usuarios = _usuarioService.ListarUsuarios();
                return View(usuarios);
            }
            catch (Exception)
            {
                return View("Index", "Home");
            }
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Cadastro()
        {
            return View();
        }
    }
}