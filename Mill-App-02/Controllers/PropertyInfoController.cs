using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Mill_App_02.Controllers
{
    public class PropertyInfoController : Controller
    {
        // GET: PropertyInfo
        public ViewResult Index()
        {
            PropertyInfo propertyInfo = new PropertyInfo();
            var result = propertyInfo.GetAllStudent();

            return View(result);
        }

        // GET: PropertyInfo/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PropertyInfo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PropertyInfo/Create
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

        // GET: PropertyInfo/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PropertyInfo/Edit/5
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

        // GET: PropertyInfo/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PropertyInfo/Delete/5
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