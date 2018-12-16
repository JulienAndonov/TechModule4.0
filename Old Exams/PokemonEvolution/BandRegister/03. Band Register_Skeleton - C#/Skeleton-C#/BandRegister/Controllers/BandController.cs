using System.Linq;
using System.Runtime.InteropServices;
using BandRegister.Data;
using BandRegister.Models;
using Microsoft.AspNetCore.Mvc;

namespace BandRegister.Controllers
{
    public class BandController : Controller
    {
        public IActionResult Index()
        {
            using (var db = new BandRegisterDbContext())
            {
                var bands = db.Bands.ToList();
                return View(bands);
            }
        }

        [HttpGet]
        public IActionResult Create()
        {
            //TO DO
            return View();
        }

        [HttpPost]
        public IActionResult Create(Band band)
        {
            using (var db = new BandRegisterDbContext())
            {
                if (band != null)
                {
                    db.Bands.Add(band);
                    db.SaveChanges();

                }
                else
                {
                    return View();
                }

                return RedirectToAction("Index");
            }
            return null;
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            using (var db = new BandRegisterDbContext())
            {
                Band band = db.Bands.Find(id);


                return View(band);
            }
        }

        [HttpPost]
        public IActionResult Edit(Band band)
        {
            using (var db = new BandRegisterDbContext())
            {
                db.Bands.Update(band);
                db.SaveChanges();
            }


            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            using (var db = new BandRegisterDbContext())
            {

                if (id != null)
                {
                    Band band = db.Bands.Find(id);
                    return View(band);
                }
            }
            return View();
        }

        [HttpPost]
        public IActionResult Delete(Band band)
        {
            using (var db = new BandRegisterDbContext())
            {
                db.Bands.Remove(band);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}