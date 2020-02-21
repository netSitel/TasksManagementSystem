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
            return View();
        }

        public PartialViewResult Modifiko(string Id)
        {
            Helper hp = new Helper();
            AdminViewModel model = new AdminViewModel();
            model.SelectListEntity = hp.GetEntities();
            return PartialView("Index", model);

        }
    }
}