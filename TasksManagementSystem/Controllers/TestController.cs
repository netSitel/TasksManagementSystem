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
            
            List<Kategori> all = new List<Kategori>();
            using (taskDb dc = new taskDb())
            {
              var  allS = dc.SelectAllActiveRec_Entitet_kategori("tbl_Analize").OrderBy(a => a.id_sup).ToList();
                foreach (var item in allS)
                {
                    Kategori model = new Kategori();
                    model.id = item.nrrendor;
                    model.text = item.emertimi;
                    model.parentId = Convert.ToInt32(item.id_sup);
                    all.Add(model);


                }
            }

            return View(all.OrderBy(a => a.parentId).ToList());
        }

    }
 

}