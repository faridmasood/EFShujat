using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EF.Models;
using Data;
using Data.Repositories;
using Data.Entities;
using System.Threading.Tasks;

namespace EF.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUnitOFWork _unitOFWork;

        public HomeController(ILogger<HomeController> logger, IUnitOFWork unitOFWork)
        {
            _logger = logger;
            _unitOFWork = unitOFWork;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _unitOFWork.Blogs.GetWithoutPosts(1);

            var blog = new Blog()
            {
                Title = "Special blog"
            };
            await _unitOFWork.Blogs.Create(blog);

            var post = new Post()
            {
                Title = "Post Three",
                Descption = "DESC",
                Likes = 1,
                Blog = blog
            };
            await _unitOFWork.Posts.Create(post);

            await _unitOFWork.Save();

            return View();
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