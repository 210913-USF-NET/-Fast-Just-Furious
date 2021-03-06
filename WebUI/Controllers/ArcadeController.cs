using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebUI.Models;

namespace WebUI.Controllers
{
    public class ArcadeController : Controller
    {
        // GET: ArcadeController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ArcadeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ArcadeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ArcadeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Arcade arcade)
        {
            try
            {

                return View("Index", arcade);
            }
            catch
            {
                return View();
            }
        }

        // GET: ArcadeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ArcadeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ArcadeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ArcadeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
