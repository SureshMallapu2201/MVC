using MVC.Models;
using MVC.Services;
using MVC.Services.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class UserController : Controller
    {
        private readonly IUser _IUser;
        public UserController()
        {
            _IUser = new User();
        }
        // GET: User
        public ActionResult Index()
        {
            user user = new user();
            return View(user);
        }

        public ActionResult SaveUser(user user)
        {
            
                try
                {
                    _IUser.SaveUser(user);
                    ViewBag.message = "User Details Saved Successfully.";
                    
                }
                catch(Exception ex)
                {
                    ViewBag.Errormessage = "Error Occured While Saving Data";
                    
                }
            return RedirectToAction("Index");

        }
    }
}