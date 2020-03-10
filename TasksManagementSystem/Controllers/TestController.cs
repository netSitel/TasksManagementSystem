using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TasksManagementSystem.KlasatNdihmese;
using TasksManagementSystem.Models;
using TasksManagementSystem.Repositores;

namespace TasksManagementSystem.Controllers
{
    public class TestController : Controller
    {
        BaseRepository repository = new BaseRepository();
        // GET: Test

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Modal()
        {
            return PartialView();
        }

    }
 

}