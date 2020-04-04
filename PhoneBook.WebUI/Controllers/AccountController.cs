using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using PhoneBook.WebUI.Identity;
using PhoneBook.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using Login = PhoneBook.WebUI.Models.Login;

namespace PhoneBook.WebUI.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<ApplicationUser> UserManager;
        private RoleManager<ApplicationRole> RoleManager;

        public AccountController()
        {
            var userStore = new UserStore<ApplicationUser>(new IdentityDataContext());
            UserManager = new UserManager<ApplicationUser>(userStore);

            var roleStore = new RoleStore<ApplicationRole>(new IdentityDataContext());
            RoleManager = new RoleManager<ApplicationRole>(roleStore); 
        
        
        }
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(Register model)
        {

            if (ModelState.IsValid)
            {
                ApplicationUser user = new ApplicationUser();
                user.Name = model.Name;
                user.UserName = model.UserName;
                user.Surname = model.SurName;
                user.Email = model.Email;


               IdentityResult result= UserManager.Create(user, model.Password);


                if (result.Succeeded)
                {
                    if (RoleManager.RoleExists("admin"))
                    {
                        UserManager.AddToRole(user.Id, "admin");
                    }

                    return RedirectToAction("Login", "Account");
                  
                }
                else
                {
                    ModelState.AddModelError("usercreateerror", "User could not create");
                }





            }
            return View(model);

        }



        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Login model)
        {
            if (ModelState.IsValid)
            {
                var user = UserManager.Find(model.UserName, model.Password);

                if (user!=null)
                {
                    var authManager = HttpContext.GetOwinContext().Authentication;


                    var identityclaims = UserManager.CreateIdentity(user, "ApplicationCookie");

                    var authProperties = new AuthenticationProperties();

                    authProperties.IsPersistent = model.RememberMe;

                    authManager.SignIn(authProperties, identityclaims);

                    return RedirectToAction("Index","Employee");

                }
                else
                {
                    ModelState.AddModelError("Login Error", "Kayıtlı kullanıcı bulunamadı");
                }


            }
            return View(model);

        }

        public ActionResult Logout()
        {
            var authManager = HttpContext.GetOwinContext().Authentication;
            authManager.SignOut();


            return RedirectToAction("Index","Home");
        }

         

    }
}