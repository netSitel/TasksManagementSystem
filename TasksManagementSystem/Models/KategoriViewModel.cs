using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TasksManagementSystem.Models
{
    public class KategoriViewModel
    {
        public int SelectedEntity { get; set; }
        public string table { get; set; }
        public List<SelectListItem> SelectListKategori { get; set; }
        public List<konfigurime> konfigurimet { get; set; }
        public List<SelectListItem> SelectKategoriParent { get; set; }
        public SelectAllActiveRec_Entitet_kategori_Result Entitet { get; set; }
    }
}