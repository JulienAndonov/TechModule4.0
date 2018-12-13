using Microsoft.AspNetCore.Mvc;
using Phonebook.Data;
using Phonebook.Data.Models;
using System.Collections.Generic;

namespace Phonebook.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {

            /*
            DataAccess.Contacts.Add(new Contact
            {
               

            });

            var contact = DataAccess.Contacts;
            */


            var model = DataAccess.Contacts;

            return View(model);
        }
    }
}
