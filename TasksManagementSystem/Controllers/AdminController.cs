using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
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
                using (var context = new taskDb())
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
            using (var context = new taskDb())
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
            using (var context = new taskDb())
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
            List<Tipe> list = new List<Tipe>();
            using (var db=new taskDb())
            {
                
                var lista = db.SelectAllActiveRec_nder_Entitet_tip_kategori("tbl_nder_" + name).ToList();
                List<SelectAllActiveRec_Entitet_tip_Result> listaReale = db.SelectAllActiveRec_Entitet_tip("tbl_" + name).Where(a=>a.aktiv==true).ToList();
                List<SelectAllActiveRec_Entitet_tip_Result> listaReale1 = new List<SelectAllActiveRec_Entitet_tip_Result>();
                foreach (var item in listaReale)
                { foreach(var item1 in lista)
                    {
                        if (item.nrrendor == item1.Entitet_tip_id)
                        {
                            listaReale1.Add(item);

                        }
                    }

                }
                model.EntitetTipList = listaReale1;

            }

            return PartialView("_AfishoTipe",model);
        }

        public ActionResult NewTipPopUp(string idKategori,string name)
        {
            TipiViewModel model = new TipiViewModel();
            model.table = name;
            model.SelectedKategoriId = Convert.ToInt32(idKategori);
            return PartialView("_NewTip",model);
        }

        public ActionResult SaveNewTip(TipiViewModel model)
        {
            bool True = true;
            using (var db = new taskDb())
            {
                db.spI_tbl_Analize_tip(model.EntitetTip.id_sup, True, model.EntitetTip.kodi, model.EntitetTip.kodifillim, model.EntitetTip.kodimbarim, model.EntitetTip.kodiaktual, model.EntitetTip.emertimi, model.EntitetTip.pershkrimi, model.EntitetTip.emertimiang, model.EntitetTip.pershkrimiang, model.EntitetTip.rradha, model.EntitetTip.perdorues_id);
                db.SaveChanges();
               int a= db.SelectAllActiveRec_Entitet_tip("tbl_Analize").OrderByDescending(i=>i.nrrendor).FirstOrDefault().nrrendor;
                db.spI_tbl_nder_Analize_tip_kategori(-1, a, model.SelectedKategoriId, model.EntitetTip.perdorues_id);
            }

            return RedirectToAction("Index");
        }

       public ActionResult EditimTipPopUp(string idKategori,string name,string id)
        {
            Helper hp = new Helper();
            int ID = Convert.ToInt32(id);
            TipiViewModel model = new TipiViewModel();
            model.table = name;
            model.SelectTipParent = hp.GetKategori("tbl_" + name);
            using (var db = new taskDb())
            {
                model.EntitetTip = db.SelectAllActiveRec_Entitet_tip("tbl_" + name).Where(i => i.nrrendor == ID && i.aktiv == true).ToList().FirstOrDefault();

                if (model.EntitetTip.id_sup == ID)
                {
                    ViewBag.Delete = 1;

                }

            }
            return PartialView("EditimTipPopUp",model);
        }

        public ActionResult SaveEditedTip(TipiViewModel model)
        {
            using (var db = new taskDb())
            {
                var True = true;
                if (model.table == "Analize")
                {
                    db.spU_tbl_Analize_tip(model.EntitetTip.nrrendor, model.EntitetTip.id_sup,True, 1, True, model.EntitetTip.kodi, True,model.EntitetTip.kodifillim,True,model.EntitetTip.kodiaktual, True,model.EntitetTip.kodimbarim, True, model.EntitetTip.emertimi, True, model.EntitetTip.pershkrimi, True, model.EntitetTip.emertimiang, True, model.EntitetTip.pershkrimiang, True, True, True, model.EntitetTip.perdorues_id, True);
        
                    }
                else if (model.table == "Niveli")
                {
                    db.spU_tbl_niveli_tip(model.EntitetTip.nrrendor, model.EntitetTip.id_sup, True, 1, True, model.EntitetTip.kodi, True, model.EntitetTip.kodifillim, True, model.EntitetTip.kodiaktual, True, model.EntitetTip.kodimbarim, True, model.EntitetTip.emertimi, True, model.EntitetTip.pershkrimi, True, model.EntitetTip.emertimiang, True, model.EntitetTip.pershkrimiang, True, True, True, model.EntitetTip.perdorues_id, True);
                }

                else if (model.table == "Klient")
                {
                    db.spU_tbl_klient_tip(model.EntitetTip.nrrendor, model.EntitetTip.id_sup, True, 1, True, model.EntitetTip.kodi, True, model.EntitetTip.kodifillim, True, model.EntitetTip.kodiaktual, True, model.EntitetTip.kodimbarim, True, model.EntitetTip.emertimi, True, model.EntitetTip.pershkrimi, True, model.EntitetTip.emertimiang, True, model.EntitetTip.pershkrimiang, True, True, True, model.EntitetTip.perdorues_id, True);

                }
                else if (model.table == "Personel")
                {
                    db.spU_tbl_personel_tip(model.EntitetTip.nrrendor, model.EntitetTip.id_sup, True, 1, True, model.EntitetTip.kodi, True, model.EntitetTip.kodifillim, True, model.EntitetTip.kodiaktual, True, model.EntitetTip.kodimbarim, True, model.EntitetTip.emertimi, True, model.EntitetTip.pershkrimi, True, model.EntitetTip.emertimiang, True, model.EntitetTip.pershkrimiang, True, True, True, model.EntitetTip.perdorues_id, True);
                }
                else if (model.table == "Pyetje")
                {
                    db.spU_tbl_pyetje_tip(model.EntitetTip.nrrendor, model.EntitetTip.id_sup, True, 1, True, model.EntitetTip.kodi, True, model.EntitetTip.kodifillim, True, model.EntitetTip.kodiaktual, True, model.EntitetTip.kodimbarim, True, model.EntitetTip.emertimi, True, model.EntitetTip.pershkrimi, True, model.EntitetTip.emertimiang, True, model.EntitetTip.pershkrimiang, True, True, True, model.EntitetTip.perdorues_id, True);

                }
                else if (model.table == "Project")
                {
                    db.spU_tbl_project_tip(model.EntitetTip.nrrendor, model.EntitetTip.id_sup, True, 1, True, model.EntitetTip.kodi, True, model.EntitetTip.kodifillim, True, model.EntitetTip.kodiaktual, True, model.EntitetTip.kodimbarim, True, model.EntitetTip.emertimi, True, model.EntitetTip.pershkrimi, True, model.EntitetTip.emertimiang, True, model.EntitetTip.pershkrimiang, True, True, True, model.EntitetTip.perdorues_id, True);

                }
                else if (model.table == "Skeda")
                {
                    db.spU_tbl_skeda_tip(model.EntitetTip.nrrendor, model.EntitetTip.id_sup, True, 1, True, model.EntitetTip.kodi, True, model.EntitetTip.kodifillim, True, model.EntitetTip.kodiaktual, True, model.EntitetTip.kodimbarim, True, model.EntitetTip.emertimi, True, model.EntitetTip.pershkrimi, True, model.EntitetTip.emertimiang, True, model.EntitetTip.pershkrimiang, True, True, True, model.EntitetTip.perdorues_id, True);

                }
                else if (model.table == "Task")
                {
                    db.spU_tbl_task_tip(model.EntitetTip.nrrendor, model.EntitetTip.id_sup, True, 1, True, model.EntitetTip.kodi, True, model.EntitetTip.kodifillim, True, model.EntitetTip.kodiaktual, True, model.EntitetTip.kodimbarim, True, model.EntitetTip.emertimi, True, model.EntitetTip.pershkrimi, True, model.EntitetTip.emertimiang, True, model.EntitetTip.pershkrimiang, True, True, True, model.EntitetTip.perdorues_id, True);

                }
                else if (model.table == "Teknologji")
                {
                    db.spU_tbl_teknologjia_tip(model.EntitetTip.nrrendor, model.EntitetTip.id_sup, True, 1, True, model.EntitetTip.kodi, True, model.EntitetTip.kodifillim, True, model.EntitetTip.kodiaktual, True, model.EntitetTip.kodimbarim, True, model.EntitetTip.emertimi, True, model.EntitetTip.pershkrimi, True, model.EntitetTip.emertimiang, True, model.EntitetTip.pershkrimiang, True, True, True, model.EntitetTip.perdorues_id, True);

                }
            }
        

            return RedirectToAction("Index");
        }

        public ActionResult DeleteTip(string id,string table)
        {
            using (var db = new taskDb())
            {
                var model = db.SelectAllActiveRec_Entitet_tip("tbl_"+table).Where(i => i.nrrendor == Convert.ToInt32(id)).FirstOrDefault();
                model.aktiv = false;
                var True = true;
                if (table == "Analize")
                {
                    db.spU_tbl_Analize_tip(model.nrrendor, model.id_sup, True, 1, True, model.kodi, True, model.kodifillim, True, model.kodiaktual, True, model.kodimbarim, True, model.emertimi, True, model.pershkrimi, True, model.emertimiang, True, model.pershkrimiang, True,model.aktiv, True, model.perdorues_id, True);

                }
                else if (table == "Niveli")
                {
                    db.spU_tbl_niveli_tip(model.nrrendor, model.id_sup, True, 1, True, model.kodi, True, model.kodifillim, True, model.kodiaktual, True, model.kodimbarim, True, model.emertimi, True, model.pershkrimi, True, model.emertimiang, True, model.pershkrimiang, True, model.aktiv, True, model.perdorues_id, True);
                }

                else if (table == "Klient")
                {
                    db.spU_tbl_klient_tip(model.nrrendor, model.id_sup, True, 1, True, model.kodi, True, model.kodifillim, True, model.kodiaktual, True, model.kodimbarim, True, model.emertimi, True, model.pershkrimi, True, model.emertimiang, True, model.pershkrimiang, True, model.aktiv, True, model.perdorues_id, True);

                }
                else if (table == "Personel")
                {
                    db.spU_tbl_personel_tip(model.nrrendor, model.id_sup, True, 1, True, model.kodi, True, model.kodifillim, True, model.kodiaktual, True, model.kodimbarim, True, model.emertimi, True, model.pershkrimi, True, model.emertimiang, True, model.pershkrimiang, True, model.aktiv, True, model.perdorues_id, True);
                }
                else if (table == "Pyetje")
                {
                    db.spU_tbl_pyetje_tip(model.nrrendor, model.id_sup, True, 1, True, model.kodi, True, model.kodifillim, True, model.kodiaktual, True, model.kodimbarim, True, model.emertimi, True, model.pershkrimi, True, model.emertimiang, True, model.pershkrimiang, True, model.aktiv, True, model.perdorues_id, True);

                }
                else if (table == "Project")
                {
                    db.spU_tbl_project_tip(model.nrrendor, model.id_sup, True, 1, True, model.kodi, True, model.kodifillim, True, model.kodiaktual, True, model.kodimbarim, True, model.emertimi, True, model.pershkrimi, True, model.emertimiang, True, model.pershkrimiang, True, model.aktiv, True, model.perdorues_id, True);

                }
                else if (table == "Skeda")
                {
                    db.spU_tbl_skeda_tip(model.nrrendor, model.id_sup, True, 1, True, model.kodi, True, model.kodifillim, True, model.kodiaktual, True, model.kodimbarim, True, model.emertimi, True, model.pershkrimi, True, model.emertimiang, True, model.pershkrimiang, True, model.aktiv, True, model.perdorues_id, True);

                }
                else if (table == "Task")
                {
                    db.spU_tbl_task_tip(model.nrrendor, model.id_sup, True, 1, True, model.kodi, True, model.kodifillim, True, model.kodiaktual, True, model.kodimbarim, True, model.emertimi, True, model.pershkrimi, True, model.emertimiang, True, model.pershkrimiang, True, model.aktiv, True, model.perdorues_id, True);

                }
                else if (table == "Teknologji")
                {
                    db.spU_tbl_teknologjia_tip(model.nrrendor, model.id_sup, True, 1, True, model.kodi, True, model.kodifillim, True, model.kodiaktual, True, model.kodimbarim, True, model.emertimi, True, model.pershkrimi, True, model.emertimiang, True, model.pershkrimiang, True, model.aktiv, True, model.perdorues_id, True);

                }
            }

            return RedirectToAction("Index");
        }
        
        public PartialViewResult ModifikoPerdorues()
        {
            
            PerdoruesViewModel model = new PerdoruesViewModel();
            using (var db=new taskDb())
            {
                model.UsersList = db.AspNetUsers.ToList();
            }
                return PartialView("_ModifikoPerdoues", model);

        }
        public ActionResult EditoPerdorues(string id)
        {
            Helper hp = new Helper();
            PerdoruesViewModel model = new PerdoruesViewModel();
            model.UsersRoles = hp.GetRole();
            using (var db=new taskDb())
            {
                model.Users = db.AspNetUsers.Where(i => i.Id.Equals(id)).FirstOrDefault();
                if (db.AspNetUsers.Where(i => i.Id.Equals(id)).FirstOrDefault().AspNetRoles.Count() > 0)
                {
                    model.SelectedRole = db.AspNetUsers.Where(i => i.Id.Equals(id)).FirstOrDefault().AspNetRoles.FirstOrDefault().Id;

                }
                

            }
            return PartialView("_EditoPerdorues",model);
        }
        public ActionResult SaveEditedPerdorues(PerdoruesViewModel model)
        {
            AspNetRoles roles = new AspNetRoles();
     
           
            using (var db=new taskDb())
            {
                db.AspNetUsers.Add(model.Users);
                db.Entry(model.Users).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                db.AspNetRoles.Where(a => a.Id == model.SelectedRole).FirstOrDefault().AspNetUsers.Add(model.Users);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        public ActionResult DeletePerdorues(string id)
        {
            using (var db = new taskDb())
            {
                AspNetUsers model = new AspNetUsers();
                model.Id = id;
               
                db.Entry(model).State = EntityState.Deleted;
                db.SaveChanges();
            }
                return RedirectToAction("Index");
        }






        public ActionResult NestedTree(string table)
        {

            List<Kategori> list = new List<Kategori>();

            using (var db = new taskDb())
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

                using (var db = new taskDb())
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
            using (var db = new taskDb())
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
            using (var db = new taskDb())
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

            using (var db = new taskDb())
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
            using (var db = new taskDb())
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
