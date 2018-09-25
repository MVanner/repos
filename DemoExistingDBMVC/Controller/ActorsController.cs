using DemoExistingDBMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoExistingDBMVC
{
    public class ActorsController : Controller
    {
        private ActorDbContext _Context;
        public ActorsController(ActorDbContext context)
        {
            _Context = context;
        }

        public IActionResult Index()
        {
            return View(_Context.Actors.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Actors actors)
        {
            if (ModelState.IsValid)
            {
                _Context.Actors.Add(actors);
                _Context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(actors);
        }

    }
}
