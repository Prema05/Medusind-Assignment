using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;
using System.Data;
using System.Data.Entity;
using System.Net;

namespace WebApplication2.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        masterEntities db = new masterEntities();
        public ActionResult Index()
        {
            List<Movie> movie = db.Movies.ToList();
            return View(movie);
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost, ActionName("Create")]
        [ValidateAntiForgeryToken]
        public ActionResult Insert([Bind(Include = "Mid, Moviename, DateofRelease")] Movie movie)
        {
            if (ModelState.IsValid)
            {
                db.Movies.Add(movie);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(movie);
        }
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Movie movie = db.Movies.Find(id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include ="Mid, Moviename, DateofRelease")]Movie movie)
        {
            if (ModelState.IsValid)
            {
                db.Entry(movie).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(movie);
        }
        public ActionResult Delete(int ? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Movie movie = db.Movies.Find(id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }
        [HttpPost]
        [ValidateAntiForgeryToken, ActionName("Delete")]
        public ActionResult DeleteConfirm(int ? id)
        {
            Movie movie = db.Movies.Find(id);
            db.Movies.Remove(movie);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult FindMoviesByYear(DateTime? dateTime)
        {
            if (dateTime.HasValue)
            {
                int n = Convert.ToInt32(dateTime);
                IEnumerable<Movie> movie = from m in db.Movies
                                           where m.DateofRelease.Equals(n)
                                           select m;
                return View(movie);
            }
            else
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
        }
    }
}