using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TasksManagementSystem.Models;

namespace TasksManagementSystem.KlasatNdihmese
{
    public class Helper
    {



        public List<SelectListItem> GetEntities()
        {
            using (var context = new taskDb())
            {
                List<SelectListItem> Entietet = new List<SelectListItem>();
                Entietet = context.entitetet.Select(n => new SelectListItem
                {
                    Value = n.nrrendor.ToString(),
                    Text = n.entitet
                }).ToList();
                var entitetTip = new SelectListItem()
                {
                    Value = null,
                    Text = "--Zgjidh--"
                };
                Entietet.Insert(0, entitetTip);



                return Entietet;
            }

        }
        public List<SelectListItem> GetKategori(string table)
        {
            using (var context = new taskDb())
            {
                List<SelectListItem> Kategori = new List<SelectListItem>();
                Kategori = context.SelectAllActiveRec_Entitet_kategori(table).Where(a => a.aktiv==true).Select(n => new SelectListItem
                {
                    Value = n.nrrendor.ToString(),
                    Text = n.emertimi
                }).ToList();
                var entitetTip = new SelectListItem()
                {
                    Value = "-1",
                    Text = "--Zgjidh--"
                };
                Kategori.Insert(0, entitetTip);



                return Kategori;
            }

        }
        public List<SelectListItem> GetTip(string table)
        {
            using (var context = new taskDb())
            {
                List<SelectListItem> tipe = new List<SelectListItem>();
                tipe = context.SelectAllActiveRec_Entitet_tip(table).Where(a => a.aktiv == true).Select(n => new SelectListItem
                {
                    Value = n.nrrendor.ToString(),
                    Text = n.emertimi
                }).ToList();
                var entitetTip = new SelectListItem()
                {
                    Value = "-1",
                    Text = "--Zgjidh--"
                };
                tipe.Insert(0, entitetTip);



                return tipe;
            }

        }

    }
}

       

    
