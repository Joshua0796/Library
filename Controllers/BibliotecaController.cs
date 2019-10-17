using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProyectLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace ProyectLibrary.Controllers
{
    public class BibliotecaController : Controller
    {
        // GET: Biblioteca
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult About()
        {
            return View();
        }
        // GET: Biblioteca/Details/5
        public ActionResult Details()
        {
               return View();
        }  


        // GET: Biblioteca/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Biblioteca/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Biblioteca/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Biblioteca/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Biblioteca/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Biblioteca/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }


    }
}