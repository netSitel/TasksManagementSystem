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

        public ActionResult OnDemand()
        {
            List<KategoriView> all = new List<KategoriView>();
            using (taskDb dc = new taskDb())
            {
                all = dc.KategoriView.Where(a => a.ParentId.Equals(-1)).ToList();
            }

            return View(all);
        }

        public JsonResult GetSubMenu(string pid,string table)
        {
            // this action for Get Sub Menus from database and return as json data
            System.Threading.Thread.Sleep(5000);
            List<KategoriView> subMenus = new List<KategoriView>();
            int pID = 0;
            int.TryParse(pid, out pID);
            using (taskDb dc = new taskDb())
            {
                subMenus = dc.KategoriView.Where(a => a.ParentId.Equals(pID)).OrderBy(a => a.Text).ToList();
            }

            return new JsonResult { Data = subMenus, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }
    }


}