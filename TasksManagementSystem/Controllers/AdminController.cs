using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TasksManagementSystem.KlasatNdihmese;
using TasksManagementSystem.Models;

namespace TasksManagementSystem.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            AdminViewModel model = new AdminViewModel();
            using (var context = new tasketDb()) {
                model.konfigurimet = context.konfigurime.ToList();
            }

                return View(model);
        }

        public ActionResult Modifiko(int Id)
        {
            if (Id == 1)
            {
                RedirectToAction("ModifikoKategori");
            }
            else if (Id == 2)
            {
                RedirectToAction("ModifikoTipi");
            }
            else if (Id == 3)
            {
                RedirectToAction("ModifikoVeti");
            }
            else RedirectToAction("ModifikoPerdoues");
            return null;
        }
        public PartialViewResult ModifikoKategori(int Id)
        {
            Helper hp = new Helper();
            AdminViewModel model = new AdminViewModel();
            model.SelectListEntity = hp.GetEntities();
            return PartialView("Index", model);

        }
        public PartialViewResult ModifikoTipi(int Id)
        {
            Helper hp = new Helper();
            AdminViewModel model = new AdminViewModel();
            model.SelectListEntity = hp.GetEntities();
            return PartialView("Index", model);

        }
        public PartialViewResult ModifikoVeti(int Id)
        {
            Helper hp = new Helper();
            AdminViewModel model = new AdminViewModel();
            model.SelectListEntity = hp.GetEntities();
            return PartialView("Index", model);

        }
        public PartialViewResult ModifikoPerdoues(int Id)
        {
            Helper hp = new Helper();
            AdminViewModel model = new AdminViewModel();
            model.SelectListEntity = hp.GetEntities();
            return PartialView("Index", model);

        }

    }
}