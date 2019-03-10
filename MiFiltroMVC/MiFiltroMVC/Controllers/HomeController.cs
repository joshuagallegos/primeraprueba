using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MiFiltroMVC.Controllers
{
    public class HomeController : Controller
    {
        [Authorize]
        // GET: Home
        public string Index()
        {
            return "Este es mi controlador Home";
        }

        [Authorize (Roles = "admin")]
        [OutputCache (Duration = 10)]

        public string HoraActual(){
            return DateTime.Now.ToString("T");
        }
    }
}