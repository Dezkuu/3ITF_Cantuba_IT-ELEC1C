using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CantubaITELEC1C.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit

namespace CantubaITELEC1C.Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<User> _signInManager;
        public AccountController(SignInManager<User> signInManager)
        {
            _signInManager = signInManager;
        }
        // GET: /<controller>/
        public IActionResult login()
        {
            return View();
        }


    }
}