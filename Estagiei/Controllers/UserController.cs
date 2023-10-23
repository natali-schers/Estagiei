using Estagiei.Models.DAL;
using Estagiei.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Estagiei.Controllers
{
    public class UserController : Controller
    {
        private IUserRepository _userRepository;

        public UserController()
        {
            _userRepository = new UserRepository(new UserDBContext());
        }

        [HttpGet]
        public ActionResult Index()
        {
            var user = _userRepository.GetAll();
            return View(user);
        }

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(tbUser user)
        {
            if (ModelState.IsValid)
            {
                _userRepository.Insert(user);
                _userRepository.Save();
                return RedirectToAction("Index", "User");
            }
            return View();
        }

        [HttpGet]
        public ActionResult Edit(int userId)
        {

            tbUser user = _userRepository.GetById(userId);
            return View(user);
        }

        [HttpPost]
        public ActionResult Edit(tbUser user)
        {
            if (ModelState.IsValid)
            {
                _userRepository.Update(user);
                _userRepository.Save();
                return RedirectToAction("Index", "User");
            }
            else
            {
                return View(user);
            }
        }
        [HttpGet]
        public ActionResult Delete(int userId)
        {
             tbUser user = _userRepository.GetById(userId);
             return View(user);
        } 

         [HttpPost]
        public ActionResult DeleteUser(int userId)
        {
             _userRepository.Delete(userId);
             _userRepository.Save();
             return RedirectToAction("Index", "User");
        }
    }
}