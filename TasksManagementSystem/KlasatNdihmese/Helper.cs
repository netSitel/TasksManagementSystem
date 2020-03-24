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
        public List<SelectListItem> GetTip(string table,string id,string idT)
        {
            using (var context = new taskDb())
            {
                var list = context.SelectAllActiveRec_nder_Entitet_tip_kategori("tbl_nder_"+table).Where(i => i.Entitet_tip_kategori_id == Convert.ToInt32(id)&&i.aktiv==true).ToList();
                List<SelectAllActiveRec_Entitet_tip_Result> listTipe = new List<SelectAllActiveRec_Entitet_tip_Result>();

                List<SelectListItem> tipe = new List<SelectListItem>();
                foreach (var item in context.SelectAllActiveRec_Entitet_tip("tbl_" + table).Where(a => a.aktiv == true).ToList())
                {
                    foreach(var item1 in list)
                    {
                        if (item.nrrendor == item1.Entitet_tip_id && item.nrrendor!=Convert.ToInt32(idT))
                        {
                            listTipe.Add(item);
                        }
                    }
                }
                
                    tipe = listTipe.Select(n => new SelectListItem
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
            public List<SelectListItem> GetRole()
            {
                using (var context = new taskDb())
                {
                    List<SelectListItem> Role = new List<SelectListItem>();
                    Role = context.AspNetRoles.Select(n => new SelectListItem
                    {
                        Value = n.Id.ToString(),
                        Text = n.Name
                    }).ToList();
                    var entitetTip = new SelectListItem()
                    {
                        Value = "-1",
                        Text = "--Zgjidh--"
                    };
                    Role.Insert(0, entitetTip);
                    



                    return Role;
                }

            }

    }
}

       

    
