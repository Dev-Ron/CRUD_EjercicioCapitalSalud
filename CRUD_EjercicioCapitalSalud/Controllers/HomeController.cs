using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRUD_EjercicioCapitalSalud.Data;
using Microsoft.AspNetCore.Mvc;

namespace CRUD_EjercicioCapitalSalud.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }

    }
}
