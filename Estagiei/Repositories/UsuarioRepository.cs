using Estagiei.Models;
using EstagieiConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Estagiei.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        #region Dependências
        private readonly EstagieiConnectionDB db;

        public UsuarioRepository()
        {
            db = new EstagieiConnectionDB();
        }

        public UsuarioRepository(EstagieiConnectionDB context)
        {
            db = context;
        }
        #endregion Dependências

        public List<Usuario> ListarUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();

            try
            {
                usuarios = db.Fetch<Usuario>(@"SELECT * FROM usuario WITH(NOLOCK) WHERE id > 0").ToList();
                return usuarios;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}