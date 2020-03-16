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


        public PartialViewResult ModifikoTipe()
        {

            TipiViewModel TipiViewModel = new TipiViewModel();


            Helper hp = new Helper();
            AdminViewModel model = new AdminViewModel();
            model.SelectListEntity = hp.GetEntities();
            TipiViewModel.SelectListEntity = hp.GetEntities();
            using (var context = new tasketDb())
            {
                model.konfigurimet = context.konfigurime.ToList();


            }

            return PartialView("_ModifikoTipe", TipiViewModel);


        }
        public ActionResult AfishoTipe(string idKategori, string name)
        {

            TipiViewModel model = new TipiViewModel();
            model.SelectedKategoriId = Convert.ToInt32(idKategori);
            model.table = name;
            using(var db=new tasketDb())
            {
                model.SelectTipKategori = db.SelectAllActiveRec_nder_Entitet_tip_kategori("tbl_" + name).ToList();
            }

                return View();
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
                AllCategories = db.SelectAllActiveRec_Entitet_kategori("tbl_" + table).Where(a => a.aktiv = true).OrderBy(a => a.nrrendor).ToList();
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
            return PartialView("NestedTree", list);
        }


            public ActionResult NestedTreeForTipe(string table)
            {

                List<Kategori> list = new List<Kategori>();

                using (var db = new tasketDb())
                {
                    List<SelectAllActiveRec_Entitet_kategori_Result> AllCategories = new List<SelectAllActiveRec_Entitet_kategori_Result>();
                    AllCategories = db.SelectAllActiveRec_Entitet_kategori("tbl_" + table).Where(a => a.aktiv = true).OrderBy(a => a.nrrendor).ToList();
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
                return PartialView("NestedTreeForTipe", list);

            }

        [HttpPost]
        public ActionResult EditimKategoriPopUp(string id, string name)
        {

            int ID = Convert.ToInt32(id);
            KategoriViewModel model = new KategoriViewModel();
            model.table = name;
            using (var db = new tasketDb())
            {
                model.Entitet = db.SelectAllActiveRec_Entitet_kategori("tbl_" + name).Where(i => i.nrrendor == ID && i.aktiv == true).ToList().FirstOrDefault();

                if (model.Entitet.id_sup == ID)
                {
                    ViewBag.Delete = 1;

                }

            }

            return PartialView("EditimKategoriPopUp", model);
        }

        public ActionResult SaveEditedKategori(KategoriViewModel model)
        {
            using (var db = new tasketDb())
            {
                var True = true;
                if (model.table == "Analize")
                {
                    db.spU_tbl_Analize_kategori(model.Entitet.nrrendor, model.Entitet.id_sup, True, 1, True, model.Entitet.kodi, True, model.Entitet.emertimi, True, model.Entitet.pershkrimi, True, model.Entitet.emertimiang, True, model.Entitet.pershkrimiang, True, True, True, model.Entitet.perdorues_id, True);
                }
                else if (model.table == "Niveli")
                {
                    db.spU_tbl_niveli_kategori(model.Entitet.nrrendor, model.Entitet.id_sup, True, 1, True, model.Entitet.kodi, True, model.Entitet.emertimi, True, model.Entitet.pershkrimi, True, model.Entitet.emertimiang, True, model.Entitet.pershkrimiang, True, True, True, model.Entitet.perdorues_id, True);
                }

                else if (model.table == "Klient")
                {
                    db.spU_tbl_klient_kategori(model.Entitet.nrrendor, model.Entitet.id_sup, True, 1, True, model.Entitet.kodi, True, model.Entitet.emertimi, True, model.Entitet.pershkrimi, True, model.Entitet.emertimiang, True, model.Entitet.pershkrimiang, True, True, True, model.Entitet.perdorues_id, True);

                }
                else if (model.table == "Personel")
                {
                    db.spU_tbl_personel_kategori(model.Entitet.nrrendor, model.Entitet.id_sup, True, 1, True, model.Entitet.kodi, True, model.Entitet.emertimi, True, model.Entitet.pershkrimi, True, model.Entitet.emertimiang, True, model.Entitet.pershkrimiang, True, True, True, model.Entitet.perdorues_id, True);
                }
                else if (model.table == "Pyetje")
                {
                    db.spU_tbl_pyetje_kategori(model.Entitet.nrrendor, model.Entitet.id_sup, True, 1, True, model.Entitet.kodi, True, model.Entitet.emertimi, True, model.Entitet.pershkrimi, True, model.Entitet.emertimiang, True, model.Entitet.pershkrimiang, True, True, True, model.Entitet.perdorues_id, True);

                }
                else if (model.table == "Project")
                {
                    db.spU_tbl_project_kategori(model.Entitet.nrrendor, model.Entitet.id_sup, True, 1, True, model.Entitet.kodi, True, model.Entitet.emertimi, True, model.Entitet.pershkrimi, True, model.Entitet.emertimiang, True, model.Entitet.pershkrimiang, True,True , True, model.Entitet.perdorues_id, True);

                }
                else if (model.table == "Skeda")
                {
                    db.spU_tbl_skeda_kategori(model.Entitet.nrrendor, model.Entitet.id_sup, True, 1, True, model.Entitet.kodi, True, model.Entitet.emertimi, True, model.Entitet.pershkrimi, True, model.Entitet.emertimiang, True, model.Entitet.pershkrimiang, True, True, True, model.Entitet.perdorues_id, True);

                }
                else if (model.table == "Task")
                {
                    db.spU_tbl_task_kategori(model.Entitet.nrrendor, model.Entitet.id_sup, True, 1, True, model.Entitet.kodi, True, model.Entitet.emertimi, True, model.Entitet.pershkrimi, True, model.Entitet.emertimiang, True, model.Entitet.pershkrimiang, True, True, True, model.Entitet.perdorues_id, True);

                }
                else if (model.table == "Teknologji")
                {
                    db.spU_tbl_teknologjia_kategori(model.Entitet.nrrendor, model.Entitet.id_sup, True, 1, True, model.Entitet.kodi, True, model.Entitet.emertimi, True, model.Entitet.pershkrimi, True, model.Entitet.emertimiang, True, model.Entitet.pershkrimiang, True, True, True, model.Entitet.perdorues_id, True);

                }
            }
            return View();
        }

        [HttpPost]
       

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
               
                else if (model.table == "tbl_Niveli")
                {
                    db.spI_tbl_niveli_kategori(model.Entitet.id_sup, True, model.Entitet.kodi, model.Entitet.emertimi, model.Entitet.pershkrimi, model.Entitet.emertimiang, model.Entitet.pershkrimiang, model.Entitet.rradha, model.Entitet.perdorues_id);

                }
                else if (model.table == "tbl_Klient")
                {
                    db.spI_tbl_klient_kategori(model.Entitet.id_sup, True, model.Entitet.kodi, model.Entitet.emertimi, model.Entitet.pershkrimi, model.Entitet.emertimiang, model.Entitet.pershkrimiang, model.Entitet.rradha, model.Entitet.perdorues_id);

                }
                else if (model.table == "tbl_Personel")
                {
                    db.spI_tbl_personel_kategori(model.Entitet.id_sup, True, model.Entitet.kodi, model.Entitet.emertimi, model.Entitet.pershkrimi, model.Entitet.emertimiang, model.Entitet.pershkrimiang, model.Entitet.rradha, model.Entitet.perdorues_id);

                }
                else if (model.table == "tbl_Pyetje") {
                    db.spI_tbl_pyetje_kategori(model.Entitet.id_sup, True, model.Entitet.kodi, model.Entitet.emertimi, model.Entitet.pershkrimi, model.Entitet.emertimiang, model.Entitet.pershkrimiang, model.Entitet.rradha, model.Entitet.perdorues_id);


                }
                else if (model.table == "tbl_Project"){
                    db.spI_tbl_project_kategori(model.Entitet.id_sup, True, model.Entitet.kodi, model.Entitet.emertimi, model.Entitet.pershkrimi, model.Entitet.emertimiang, model.Entitet.pershkrimiang, model.Entitet.rradha, model.Entitet.perdorues_id);

                }
                else if (model.table == "tbl_Skeda"){
                    db.spI_tbl_skeda_kategori(model.Entitet.id_sup, True, model.Entitet.kodi, model.Entitet.emertimi, model.Entitet.pershkrimi, model.Entitet.emertimiang, model.Entitet.pershkrimiang, model.Entitet.rradha, model.Entitet.perdorues_id);

                }
                else if (model.table == "tbl_Task") {
                    db.spI_tbl_task_kategori(model.Entitet.id_sup, True, model.Entitet.kodi, model.Entitet.emertimi, model.Entitet.pershkrimi, model.Entitet.emertimiang, model.Entitet.pershkrimiang, model.Entitet.rradha, model.Entitet.perdorues_id);

                }
                else if (model.table == "tbl_Teknologji")
                {
                    db.spI_tbl_teknologjia_kategori(model.Entitet.id_sup, True, model.Entitet.kodi, model.Entitet.emertimi, model.Entitet.pershkrimi, model.Entitet.emertimiang, model.Entitet.pershkrimiang, model.Entitet.rradha, model.Entitet.perdorues_id);

                }

           
                
            }
            return RedirectToAction("Index");
        }

        public ActionResult DeleteKategori(int id, string table)
        {
            using (var db = new tasketDb())
            {
                var DeleteAnalize = db.SelectAllActiveRec_Entitet_kategori("tbl_Analize").Where(i => i.nrrendor == id).FirstOrDefault();
                DeleteAnalize.aktiv = false;
                var True = true;
                if (table == "Analize")
                {
                    db.spU_tbl_Analize_kategori(DeleteAnalize.nrrendor, DeleteAnalize.id_sup, True, 1, True, DeleteAnalize.kodi, True, DeleteAnalize.emertimi, True, DeleteAnalize.pershkrimi, True, DeleteAnalize.emertimiang, True, DeleteAnalize.pershkrimiang, True, DeleteAnalize.aktiv, True, DeleteAnalize.perdorues_id, True);
                }
                else if (table == "Niveli")
                {
                    db.spU_tbl_niveli_kategori(DeleteAnalize.nrrendor, DeleteAnalize.id_sup, True, 1, True, DeleteAnalize.kodi, True, DeleteAnalize.emertimi, True, DeleteAnalize.pershkrimi, True, DeleteAnalize.emertimiang, True, DeleteAnalize.pershkrimiang, True, DeleteAnalize.aktiv, True, DeleteAnalize.perdorues_id, True);
                }

                else if (table == "Klient")
                {
                    db.spU_tbl_klient_kategori(DeleteAnalize.nrrendor, DeleteAnalize.id_sup, True, 1, True, DeleteAnalize.kodi, True, DeleteAnalize.emertimi, True, DeleteAnalize.pershkrimi, True, DeleteAnalize.emertimiang, True, DeleteAnalize.pershkrimiang, True, DeleteAnalize.aktiv, True, DeleteAnalize.perdorues_id, True);

                }
                else if (table == "Personel")
                {
                    db.spU_tbl_personel_kategori(DeleteAnalize.nrrendor, DeleteAnalize.id_sup, True, 1, True, DeleteAnalize.kodi, True, DeleteAnalize.emertimi, True, DeleteAnalize.pershkrimi, True, DeleteAnalize.emertimiang, True, DeleteAnalize.pershkrimiang, True, DeleteAnalize.aktiv, True, DeleteAnalize.perdorues_id, True);
                }
                else if (table == "Pyetje")
                {
                    db.spU_tbl_pyetje_kategori(DeleteAnalize.nrrendor, DeleteAnalize.id_sup, True, 1, True, DeleteAnalize.kodi, True, DeleteAnalize.emertimi, True, DeleteAnalize.pershkrimi, True, DeleteAnalize.emertimiang, True, DeleteAnalize.pershkrimiang, True, DeleteAnalize.aktiv, True, DeleteAnalize.perdorues_id, True);

                }
                else if (table == "Project")
                {
                    db.spU_tbl_project_kategori(DeleteAnalize.nrrendor, DeleteAnalize.id_sup, True, 1, True, DeleteAnalize.kodi, True, DeleteAnalize.emertimi, True, DeleteAnalize.pershkrimi, True, DeleteAnalize.emertimiang, True, DeleteAnalize.pershkrimiang, True, DeleteAnalize.aktiv, True, DeleteAnalize.perdorues_id, True);

                }
                else if (table == "Skeda")
                {
                    db.spU_tbl_skeda_kategori(DeleteAnalize.nrrendor, DeleteAnalize.id_sup, True, 1, True, DeleteAnalize.kodi, True, DeleteAnalize.emertimi, True, DeleteAnalize.pershkrimi, True, DeleteAnalize.emertimiang, True, DeleteAnalize.pershkrimiang, True, DeleteAnalize.aktiv, True, DeleteAnalize.perdorues_id, True);

                }
                else if (table == "Task")
                {
                    db.spU_tbl_task_kategori(DeleteAnalize.nrrendor, DeleteAnalize.id_sup, True, 1, True, DeleteAnalize.kodi, True, DeleteAnalize.emertimi, True, DeleteAnalize.pershkrimi, True, DeleteAnalize.emertimiang, True, DeleteAnalize.pershkrimiang, True, DeleteAnalize.aktiv, True, DeleteAnalize.perdorues_id, True);

                }
                else if(table== "Teknologji")
                {
                    db.spU_tbl_teknologjia_kategori(DeleteAnalize.nrrendor, DeleteAnalize.id_sup, True, 1, True, DeleteAnalize.kodi, True, DeleteAnalize.emertimi, True, DeleteAnalize.pershkrimi, True, DeleteAnalize.emertimiang, True, DeleteAnalize.pershkrimiang, True, DeleteAnalize.aktiv, True, DeleteAnalize.perdorues_id, True);

                }
            }

            return RedirectToAction("Index");
        }


    }
}
