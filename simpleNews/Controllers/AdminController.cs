using simpleNews.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace simpleNews.Controllers
{
    public class AdminController : Controller
    {
        private NewsContext dbNews = new NewsContext();
        public ActionResult Index()
        {
            var articles = dbNews.Articles.OrderByDescending(x => x.Date).ToList();
            return View(articles);
        }

        public ActionResult Details(int id)
        {
            var article = dbNews.Articles.Find(id);
            if (article == null)
            {
                return HttpNotFound();
            }
            return PartialView("_Details", article);
        }

        public ActionResult Edit(int id)
        {
            var article = dbNews.Articles.Find(id);
            if (article == null)
            {
                return HttpNotFound();
            }
            return PartialView("_Edit", article);
        }

        [HttpPost]
        public ActionResult Edit(Article article)
        {
            if (ModelState.IsValid)
            {
                dbNews.Entry(article).State = EntityState.Modified;
                dbNews.SaveChanges();
            }
            var articles = dbNews.Articles.OrderByDescending(x => x.Date).ToList();
            return PartialView("_RefreshList", articles);
        }

        public ActionResult Create()
        {
            return PartialView("_NewArticle");
        }

        [HttpPost]
        public ActionResult Create(Article article)
        {
            if (ModelState.IsValid)
            {
                article.Date = DateTime.Now;
                dbNews.Articles.Add(article);
                dbNews.SaveChanges();
            }
            var articles = dbNews.Articles.OrderByDescending(x => x.Date).ToList();
            return PartialView("_RefreshList", articles);
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            Article article = dbNews.Articles.Find(id);
            if (article == null)
            {
                return HttpNotFound();
            }
            dbNews.Articles.Remove(article);
            dbNews.SaveChanges();
            var articles = dbNews.Articles.OrderByDescending(x => x.Date).ToList();
            return PartialView("_RefreshList", articles);
        }
    }
}