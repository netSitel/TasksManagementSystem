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

        public ActionResult Simple()
        {
            
            List<KategoriView> all = new List<KategoriView>();
            using (taskDb dc = new taskDb())
            {
                all = dc.KategoriView.OrderBy(i => i.ParentId).ToList();
            }

            return View(all);
        }

    }
 

}