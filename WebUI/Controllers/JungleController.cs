using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
    {
    public class JungleController : Controller
        {
        // GET: JungleController
        public ActionResult Index()
            {
            return View();
            }

        // GET: JungleController/Details/5
        public ActionResult Details(int id)
            {
            return View();
            }

        // GET: JungleController/Create
        public ActionResult Create()
            {
            return View();
            }

        // POST: JungleController/Create
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

        // GET: JungleController/Edit/5
        public ActionResult Edit(int id)
            {
            return View();
            }

        // POST: JungleController/Edit/5
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

        // GET: JungleController/Delete/5
        public ActionResult Delete(int id)
            {
            return View();
            }

        // POST: JungleController/Delete/5
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
