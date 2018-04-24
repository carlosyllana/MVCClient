using Client.MVC.Models;
using Client.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Client.MVC.Controllers
{
    public class UserMvcController : Controller
    {
        // GET: UserMvc
        public ActionResult Index()
        {
            return View();
        }

        // GET: UserMvc/Details
        public ActionResult Details()
        {
            UserService uservice = new UserService();
            var model2 = uservice.GetAsync();

            return View(model2.Result);
        }

        // GET: UserMvc/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserMvc/Create
        [HttpPost]
        public ActionResult Create(UserServiceModel usuarioServiceModeln)
        {
            try
            {
                // TODO: Add insert logic here
                UserService uservice = new UserService();
                var model = uservice.SetAsync(usuarioServiceModeln).Result; ;
                UserMvc uMvc = new UserMvc();
                uMvc.Id = model.Id;
                uMvc.Nombre = model.Nombre;
                uMvc.Apellidos = model.Apellidos;
                return View(model);
            }
            catch
            {
                return View();
            }
        }

        // GET: UserMvc/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UserMvc/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: UserMvc/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UserMvc/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
