using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
    {
    public class BigMacController : Controller
        {
        // GET: BigMacController
        public ActionResult Index()
            {
            return View();
            }

        // GET: BigMacController/Details/5
        public ActionResult Details(int id)
            {
            return View();
            }

        // GET: BigMacController/Create
        public ActionResult Create()
            {
            return View();
            }

        // POST: BigMacController/Create
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

        // GET: BigMacController/Edit/5
        public ActionResult Edit(int id)
            {
            return View();
            }

        // POST: BigMacController/Edit/5
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

        // GET: BigMacController/Delete/5
        public ActionResult Delete(int id)
            {
            return View();
            }

        // POST: BigMacController/Delete/5
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
