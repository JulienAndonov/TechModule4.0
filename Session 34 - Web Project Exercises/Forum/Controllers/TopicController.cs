using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Forum.Data;
using Forum.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Forum.Controllers
{
    public class TopicController : Controller
    {

        private readonly ForumDbContext context;

        public TopicController(ForumDbContext context)
        {
            this.context = context;
        }


        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index", "Home");
            }


            var topic = this.context
                .Topics
                .Include(t => t.Author)
                .Where(t => t.Id == id)
                .FirstOrDefault();


            if (topic == null)
            {
                return RedirectToAction("Index", "Home");
            }
            return View(topic);
        }

        [Authorize]
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        public IActionResult Create(Topic topic)
        {
            if (ModelState.IsValid)
            {

                //Add missing properties

                topic.CreatedDate = DateTime.Now;
                topic.LastUpdatedDate = DateTime.Now;

                var userId = this.context
                    .Users
                    .Where(t => t.UserName == this.User.Identity.Name)
                    .FirstOrDefault()
                    .Id;

                topic.AuthordID = userId;


                //Add to db
                this.context.Topics.Add(topic);


                //Save db
                this.context.SaveChanges();

                return RedirectToAction("Index", "Home");
            }
            return View(topic);
        }


        [Authorize]
        [HttpGet]
        public IActionResult Delete(int? id)
        {

            if (id == null)
            {
                return RedirectToAction("Index", "Home");
            }

            Topic topic = this.context
                .Topics
                .Include(t => t.Author)
                .Where(t => t.Id == id)
                .FirstOrDefault();


            if (topic == null)
            {
                return RedirectToAction("Index", "Home");
            }
            return View(topic);
        }


        [Authorize]
        [HttpPost]
        public IActionResult Delete(int id)
        {

            Topic topic = this.context
                .Topics
                .Include(t => t.Author)
                .Where(t => t.Id == id)
                .FirstOrDefault();



            if (topic == null)
            {
                return RedirectToAction("Index", "Home");
            }



            if (topic.Author.UserName != User.Identity.Name)
            {
                return RedirectToAction("Index", "Home");
            }


            if (ModelState.IsValid)
            {
                this.context.Topics.Remove(topic);
                this.context.SaveChanges();
            }

            return RedirectToAction("Index", "Home");
        }



        [Authorize]
        [HttpGet]
        public IActionResult Edit(int? id)
        {

            if (id == null)
            {
                return RedirectToAction("Index", "Home");
            }

            Topic topic = this.context
                .Topics
                .Include(t => t.Author)
                .Where(t => t.Id == id)
                .FirstOrDefault();


            if (topic == null)
            {
                return RedirectToAction("Index", "Home");
            }

            return View(topic);

        }

        [Authorize]
        [HttpPost]
        public IActionResult Edit(Topic topic)
        {
            if (ModelState.IsValid)
            {
                // Get from DB
                Topic dbTopic = this.context
                       .Topics
                       .Where(t => t.Id == topic.Id)
                       .FirstOrDefault();

                if (dbTopic == null)
                {
                    return RedirectToAction("Index", "Home");
                }

                //Update Properties
                dbTopic.Title = topic.Title;
                dbTopic.Description = topic.Description;
                dbTopic.LastUpdatedDate = DateTime.Now;

                //Save to Database
                this.context.SaveChanges();
            }

            return RedirectToAction("Index", "Home");
        }


    }
}