using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace User_Registration.Controllers
{
    public class UserRegisterController : Controller
    {
        // GET: UserRegister
        [HttpGet]
        public ActionResult RegisterPage()
        {
            return View();
        }
    }
}