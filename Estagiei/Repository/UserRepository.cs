using Estagiei.Models.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Estagiei.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly UserDBContext _context;

        public UserRepository()
        {
            _context = new UserDBContext();
        }

        public UserRepository(UserDBContext context)
        {
            _context = context;
        }

        public IEnumerable<tbUser> GetAll()
        {
            return _context.User.ToList();
        }

        public tbUser GetById(int userId)
        {
            return _context.User.Find(userId);
        }

        public void Insert(tbUser user)
        {
            _context.User.Add(user);
        }

        public void Update(tbUser user)
        {
            _context.Entry(user).State = EntityState.Modified;
        }

        public void Delete(int userId)
        {
            tbUser user = _context.User.Find(userId);

            if (user != null)
            {
                _context.User.Remove(user);
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }
        private bool disposed = false;
        
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}