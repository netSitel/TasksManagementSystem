using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using TasksManagementSystem.KlasatNdihmese;
using TasksManagementSystem.Models;
using TasksManagementSystem.Repositores;
using TasksManagementSystem.Repositores.Contracts;

namespace TasksManagementSystem.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            AdminViewModel model = new AdminViewModel();
            using (var context = new tasketDb())
            {
                model.konfigurimet = context.konfigurime.ToList();
            }

            return View(model);
        }

        public ActionResult Modifiko(int Id)
        {
            if (Id == 1)
            {
                return RedirectToAction("ModifikoKategori");
            }
            else if (Id == 2)
            {
                return RedirectToAction("ModifikoTipi");
            }
            else if (Id == 3)
            {
                return RedirectToAction("ModifikoVeti");
            }
            else return RedirectToAction("ModifikoPerdoues");
        }

        public PartialViewResult ModifikoKategori(int Id)
        {
            Helper hp = new Helper();
            AdminViewModel model = new AdminViewModel();
            model.SelectListEntity = hp.GetEntities();
            return PartialView("Index", model);

        }
        public PartialViewResult ModifikoTipi()
        {
            BaseRepository repository = new BaseRepository();
           List<SelectAllActiveRec_Entitet_kategori_Result> gh = new List<SelectAllActiveRec_Entitet_kategori_Result>();
               gh = repository.SelectAllActiveRec_Entitet_kategori("tbl_Analize").ToList();
            
            Helper hp = new Helper();
            AdminViewModel model = new AdminViewModel();
            model.SelectListEntity = hp.GetEntities();
           
            using (var context = new tasketDb())
            {
                model.konfigurimet = context.konfigurime.ToList();
                

            }
            


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
