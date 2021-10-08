using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Models;

namespace WebUI.Controllers
{
    public class ZooController : Controller
    {
        // GET: ZooContoller
        public ActionResult Index()
        {
            return View();
        }

        // GET: ZooContoller/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }




        // GET: ZooContoller/Create
        public ActionResult Create()
        {
            return View();
        }
        // POST: ZooContoller/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Zoo zoo)
        {
            try
            {

                return View("Index", zoo);
            }
            catch
            {
                return View();
            }
        }

        // GET: ZooContoller/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ZooContoller/Edit/5
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

        // GET: ZooContoller/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ZooContoller/Delete/5
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
