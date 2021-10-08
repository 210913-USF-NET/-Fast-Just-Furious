using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebUI.Models;

namespace WebUI.Controllers
    {
    public class DisneyController : Controller
        {
        // GET: DisneyController
        public ActionResult Index()
            {
            return View();
            }

        // GET: DisneyController/Details/5
        public ActionResult Details(int id)
            {
            return View();
            }

        // GET: DisneyController/Create
        public ActionResult Create()
            {
            return View();
            }

        // POST: DisneyController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Disney disney)
            {
            try
                {
                return View("Index", disney);
                }
            catch
                {
                return View();
                }
            }

        // GET: DisneyController/Edit/5
        public ActionResult Edit(int id)
            {
            return View();
            }

        // POST: DisneyController/Edit/5
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

        // GET: DisneyController/Delete/5
        public ActionResult Delete(int id)
            {
            return View();
            }

        // POST: DisneyController/Delete/5
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
