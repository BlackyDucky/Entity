using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Entity.Controllers
{
    public class RegisterController : Controller
    {
        public IActionResult Index()
        {
            return View("~/Views//Register/loginpage.cshtml");
        }

        // <a asp-controller="Register" asp-action="Signup" asp-route-id="@model.prop">
        public void Signup()
        {

        }

        public void Login()
        {

        }
    }
}