using ExploreUdenHTTPS.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExploreUdenHTTPS.Controllers
{
    [Route("blog")]
    public class BlogController : Controller
    {
        // GET: /<controller>/
        [Route("")]
        public IActionResult Index()
        {
            var posts = new[]
           {
                new Post
                {
                    Title = "My blog post",
                    Posted = DateTime.Now,
                    Author = "Jess Chadwick",
                    Body = "This is a great blog post, don't you think?",
                },
                new Post
                {
                    Title = "My second blog post",
                    Posted = DateTime.Now,
                    Author = "Jess Chadwick",
                    Body = "This is ANOTHER great blog post, don't you think?",
                },
            };

            return View(posts);
        }

        [Route("{year:int}/{month:int}/{key}")]
        public IActionResult Post(int year, int month, string key)
        {
            var post = new Post
            {
                Title = "My blog post",
                Posted = DateTime.Now,
                Author = "MIG SELV",
                Body = "Ham selv"
        };
            return View(post);
        }
    }
}
