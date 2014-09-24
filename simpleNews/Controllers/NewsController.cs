using System;
using simpleNews.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace simpleNews.Controllers
{
    public class NewsController : Controller
    {
        NewsContext dbNews = new NewsContext();
        public ActionResult Index()
        {
            var articles = dbNews.Articles.OrderByDescending(x => x.Date).ToList();
            return View(articles);
        }

        public ActionResult Details(int id)
        {
            Article article = dbNews.Articles.Find(id);
            if (article == null)
            {
                return HttpNotFound();
            }
            return View(article);
        }
    }
}