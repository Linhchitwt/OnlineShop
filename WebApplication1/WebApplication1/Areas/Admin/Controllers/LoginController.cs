using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Areas.Admin.Code;
using WebApplication1.Areas.Admin.Models;

namespace WebApplication1.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Admin/Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken] //tren sever va client phai dong bo token
        public ActionResult Index(LoginModel model)
        {
            var result = new AccountModel().Login(model.UserName, model.PassWord);
            if (result == true && ModelState.IsValid)
            {

                SessionHelper.SetSession(new UserSession() { UserName = model.UserName });
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("", "LogIn False");
            }
            return View(model);
        }
    }
}