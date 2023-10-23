using Estagiei.Models.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estagiei.Repository
{
    internal interface IUserRepository
    {
        IEnumerable<tbUser> GetAll();
        tbUser GetById(int userId);
        void Insert(tbUser user);
        void Update(tbUser user);
        void Delete(int userId);
        void Save();
    }
}
