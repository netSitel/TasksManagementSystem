using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TasksManagementSystem.Models
{
    public class AdminViewModel
    {
        public int SelectedEntity { get; set; }
        string table { get; set; }
        public List<SelectListItem> SelectListEntity { get; set; }
        public List<konfigurime> konfigurimet { get; set; }
        public List<SelectListItem> SelectAnalizeParent { get; set; }
        public SelectAllActiveRec_Entitet_kategori_Result Entitet { get; set; }

    }
   
}