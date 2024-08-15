using FNI_Libray;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FNI_COMPANY.Controllers
{
    public class FNIcompanyController : Controller
    {
        private readonly FNIinterface reference;
        // GET: FNIcompanyController
        public FNIcompanyController(FNIinterface connect)
        {
            reference = connect;
        }
        public ActionResult Index()
        {
            try
            {
                return View("List", reference.Showall());
            }catch(Exception)
            {
                return View("Error");
            }
        }

        // GET: FNIcompanyController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: FNIcompanyController/Create
        public ActionResult Create()
        {
            try
            {
                return View("Insert",new FNImodel());
            }
            catch (Exception)
            {
                return View("Error");
            }
        }

        // POST: FNIcompanyController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(FNImodel connect)
        {
            try
            {
                reference.create(connect);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View("Error");
            }
        }

        // GET: FNIcompanyController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FNIcompanyController/Edit/5
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

        // GET: FNIcompanyController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FNIcompanyController/Delete/5
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
