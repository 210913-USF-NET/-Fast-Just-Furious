using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebUI.Models;

namespace WebUI.Controllers
    {
    public class ToyController : Controller
        {
        // GET: ToyController
        public ActionResult Index()
            {
            return View();
            }

        // GET: ToyController/Details/5
        public ActionResult Details(int id)
            {
            return View();
            }

        // GET: ToyController/Create
        public ActionResult Create()
            {
            return View();
            }

        // POST: ToyController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Toy toy)
            {
            try
                {
                return View("Index", toy);
                }
            catch
                {
                return View();
                }
            }

        // GET: ToyController/Edit/5
        public ActionResult Edit(int id)
            {
            return View();
            }

        // POST: ToyController/Edit/5
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

        // GET: ToyController/Delete/5
        public ActionResult Delete(int id)
            {
            return View();
            }

        // POST: ToyController/Delete/5
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
