using System;
using DataAccessLayer.DataContext;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EntityLayer.Entities;

namespace EShop.Controllers
{
    public class UserController : Controller
    {
        // GET: User

        Context1 db = new Context1();

        public ActionResult Update()
        {
            var username = (string)Session["Mail"];
            var degerler = db.Users.FirstOrDefault(x => x.Email == username);
            return View(degerler);
        }
        [HttpPost]
        public ActionResult Update(User data)
        {
            var username = (string)Session["Mail"];
            var user = db.Users.Where(x => x.Email == username).FirstOrDefault();
            user.Name = data.Name;
            user.Surname = data.Surname;
            user.Username = data.Username;
            user.Email = data.Email;
            user.Password = data.Password;
            user.RePassword = data.RePassword;
            db.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    } 

}