﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebAuthTest.Data;
using WebAuthTest.Models;
using WebAuthTest.Models.Data;
using WebAuthTest.Models.View;

namespace WebAuthTest.Controllers
{
    public class HomeController : Controller
    {
        private BubbaDbContext _ctx;

        public HomeController(BubbaDbContext ctx)
        {
            _ctx = ctx;
        }

        public IActionResult Index()
        {
            var model = new HomeIndexVM();
            model.Comments = _ctx.Posts
                .Include(p => p.Replies)
                .Where(p => p.ParentPost == null)
                .ToList();
            return View(model);
        }

        // ADDED: Bind and Prefix to bind form fields to a model object
        [HttpPost]
        public IActionResult Index([Bind("Topic,Text,ParentPostId", Prefix="Post")] Post newpost)
        {
            ModelState.AddModelError("badness", "bad crap a happenin'");
            if (ModelState.IsValid)
            {
                _ctx.Add(newpost);
                _ctx.SaveChanges();
                return RedirectToAction("Index");
            }
            var model = new HomeIndexVM();
            model.Comments = _ctx.Posts
                .Include(p => p.Replies)
                .Where(p => p.ParentPost == null)
                .ToList();
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
