using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
    {
    public class MonkeyController : Controller
        {
        // GET: MonkeyController
        public ActionResult Index()
            {
            return View();
            }

        // GET: MonkeyController/Details/5
        public ActionResult Details(int id)
            {
            return View();
            }

        // GET: MonkeyController/Create
        public ActionResult Create()
            {
            return View();
            }

        // POST: MonkeyController/Create
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

        // GET: MonkeyController/Edit/5
        public ActionResult Edit(int id)
            {
            return View();
            }

        // POST: MonkeyController/Edit/5
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

        // GET: MonkeyController/Delete/5
        public ActionResult Delete(int id)
            {
            return View();
            }

        // POST: MonkeyController/Delete/5
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
