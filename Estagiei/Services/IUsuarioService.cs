using Estagiei.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estagiei.Services
{
    public interface IUsuarioService
    {
        List<Usuario> ListarUsuarios();
    }
}
