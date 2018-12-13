using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class CatsController : Controller
    {

        public IActionResult All()
        {
            return View();



        }


        public string Details(int id)
        {
            return "Cat ID: " + id;
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}