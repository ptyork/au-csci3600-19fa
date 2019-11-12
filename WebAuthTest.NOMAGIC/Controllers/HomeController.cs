using System;
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

        [HttpPost]
        public IActionResult NewComment()
        {
            var topicList = Request.Form["Topic"];
            var textList = Request.Form["Text"];
            var parentList = Request.Form["ParentPostId"];

            bool isValid = true;

            if (topicList.Count != 1) isValid = false;
            var topic = "";
            if (isValid && topicList[0].Length >= 5 && topicList[0].Length <= 100)
            {
                topic = topicList[0];
            }
            else
            {
                isValid = false;
            }

            if (isValid && textList.Count != 1) isValid = false;
            var text = "";
            if (isValid && textList[0].Length >= 2 && textList[0].Length <= 1000)
            {
                text = textList[0];
            }
            else
            {
                isValid = false;
            }

            if (isValid)
            {
                //_ctx.Add(newpost);
                //_ctx.SaveChanges();
                return RedirectToAction("Index");
            }
            TempData["didfail"] = true;
            return RedirectToAction("Index");
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
