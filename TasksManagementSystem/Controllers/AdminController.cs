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
        BaseRepository repository = new BaseRepository();
       

        public ActionResult Index()
        {
            AdminViewModel model = new AdminViewModel();
            using (var context = new tasketDb())
            {
                model.konfigurimet = context.konfigurime.ToList();
            }

            return View(model);
           
        }

        public ActionResult Modifiko(string lloji)
        {

            return RedirectToAction("Modifiko"+lloji);
           
        }

        
        public ActionResult ModifikoKategori()
        {
           // Table += table;
           //List<SelectAllActiveRec_Entitet_kategori_Result> AllCategories = new List<SelectAllActiveRec_Entitet_kategori_Result>();
           // AllCategories = repository.SelectAllActiveRec_Entitet_kategori(Table).ToList();
            //List<SelectAllActiveRecBySup_Entitet_kategori_Result> KategoriBir = new List<SelectAllActiveRecBySup_Entitet_kategori_Result>();
            //KategoriBir = repository.SelectAllActiveRecBySup_Entitet_kategori("tbl_Analize", "5").ToList();
            KategoriViewModel kategoriViewModel = new KategoriViewModel();
            

            Helper hp = new Helper();
            AdminViewModel model = new AdminViewModel();
            model.SelectListEntity = hp.GetEntities();
            kategoriViewModel.SelectListKategori = hp.GetEntities();
            using (var context = new tasketDb())
            {
                model.konfigurimet = context.konfigurime.ToList();
                

            }

            return PartialView("_ModifikoKategori", kategoriViewModel);

        }


        public PartialViewResult ModifikoVeti(string table)
        {
            Helper hp = new Helper();
            AdminViewModel model = new AdminViewModel();
            model.SelectListEntity = hp.GetEntities();
            return PartialView("Index", model);

        }
        public PartialViewResult ModifikoPerdoues(string table)
        {
            Helper hp = new Helper();
            AdminViewModel model = new AdminViewModel();
            model.SelectListEntity = hp.GetEntities();
            return PartialView("Index", model);

        }
        public ActionResult NestedTree(string table)
        {
          
            List<Kategori> list = new List<Kategori>();

            using (var db = new tasketDb())
            {
                List<SelectAllActiveRec_Entitet_kategori_Result> AllCategories = new List<SelectAllActiveRec_Entitet_kategori_Result>();
                AllCategories = db.SelectAllActiveRec_Entitet_kategori("tbl_"+table).Where(a=>a.aktiv=true).OrderBy(a => a.nrrendor).ToList();
                foreach (var item in AllCategories)
                {
                    Kategori kategori = new Kategori();
                    kategori.id = item.nrrendor;
                    kategori.parentId = Convert.ToInt32(item.id_sup);
                    kategori.text = item.emertimi;
                    list.Add(kategori);
                }
            }
            ViewBag.Table = table;
            return PartialView("NestedTree",list);

        }

        [HttpPost]
        public ActionResult EditimKategoriPopUp(string id,string name)
        {
            
            int ID = Convert.ToInt32(id);
            KategoriViewModel model = new KategoriViewModel();
            model.Entitet = repository.SelectAllActiveRec_Entitet_kategori("tbl_"+name).Where(i => i.nrrendor > -1 && i.aktiv == true).ToList().FirstOrDefault();
           
                if (model.Entitet.id_sup == ID)
                {
                    ViewBag.Delete = 1;
                    
                }
            


            return PartialView("EditimKategoriPopUp",model);
        }



        [HttpPost]
        public ActionResult RuajAnalize(SelectAllActiveRec_Entitet_kategori_Result model)
        {
            bool True = true;
            using (var db = new tasketDb())
            {
                db.spU_tbl_Analize_kategori(model.nrrendor, model.id_sup, True, 1, True, model.kodi, True, model.emertimi, True, model.pershkrimi, True, model.emertimiang, True, model.pershkrimiang, True, True, True, model.perdorues_id, True);
                db.SaveChanges();
            }
            return RedirectToAction("NestedTree");
        }

        public ActionResult NewKategoriPopUp(string Id)
        {
            Helper hp=new Helper();
            KategoriViewModel model = new KategoriViewModel();
            model.table = "tbl_"+Id;
            model.SelectListKategori = hp.GetKategori("tbl_"+Id);
            return PartialView("_NewKategoriPopUp", model);
        }
        public ActionResult SaveNewKategori(KategoriViewModel model)
        {
            bool True = true;

            using (var db = new tasketDb())
            {

                if (model.table == "tbl_Analize")
                {
                    db.spI_tbl_Analize_kategori(model.Entitet.id_sup, True, model.Entitet.kodi, model.Entitet.emertimi, model.Entitet.pershkrimi, model.Entitet.emertimiang, model.Entitet.pershkrimiang, model.Entitet.rradha, model.Entitet.perdorues_id);
                }
                else
                {
                    db.spI_tbl_klient_kategori(model.Entitet.id_sup, True, model.Entitet.kodi, model.Entitet.emertimi, model.Entitet.pershkrimi, model.Entitet.emertimiang, model.Entitet.pershkrimiang, model.Entitet.rradha, model.Entitet.perdorues_id);

                }
            }
            return RedirectToAction("Index");
        }
        public ActionResult DeleteAnalize(int id,string table)
        {
            using (var db = new tasketDb())
            {
              var DeleteAnalize=  db.SelectAllActiveRec_Entitet_kategori("tbl_Analize").Where(i=>i.nrrendor==id).FirstOrDefault();
                DeleteAnalize.aktiv = false;
                var True = true;
                db.spU_tbl_Analize_kategori(DeleteAnalize.nrrendor, DeleteAnalize.id_sup, True, 1, True, DeleteAnalize.kodi, True, DeleteAnalize.emertimi, True, DeleteAnalize.pershkrimi, True, DeleteAnalize.emertimiang, True, DeleteAnalize.pershkrimiang, True, DeleteAnalize.aktiv, True, DeleteAnalize.perdorues_id, True);
            }

                return RedirectToAction("Index");
        }


    }
}
