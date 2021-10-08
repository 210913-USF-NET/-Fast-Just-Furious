using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
    {
    public class ParkController : Controller
        {
        // GET: ParkController
        public ActionResult Index()
            {
            return View();
            }

        // GET: ParkController/Details/5
        public ActionResult Details(int id)
            {
            return View();
            }

        // GET: ParkController/Create
        public ActionResult Create()
            {
            return View();
            }

        // POST: ParkController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: ParkController/Edit/5
        public ActionResult Edit(int id)
            {
            return View();
            }

        // POST: ParkController/Edit/5
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

        // GET: ParkController/Delete/5
        public ActionResult Delete(int id)
            {
            return View();
            }

        // POST: ParkController/Delete/5
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
