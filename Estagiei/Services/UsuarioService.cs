using Estagiei.Models;
using Estagiei.Repositories;
using EstagieiConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Estagiei.Services
{
    public class UsuarioService : IUsuarioService
    {
        #region Dependências
        private IUsuarioRepository _usuarioRepository;

        public UsuarioService()
        {
            _usuarioRepository = new UsuarioRepository(new EstagieiConnectionDB());
        }
        #endregion Dependências

        public List<Usuario> ListarUsuarios()
        {
            List<Usuario> usuarios = _usuarioRepository.ListarUsuarios();

            return usuarios;
        }
    }
}