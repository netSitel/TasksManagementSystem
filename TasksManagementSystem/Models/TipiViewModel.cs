using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TasksManagementSystem.KlasatNdihmese;

namespace TasksManagementSystem.Models
{
    public class TipiViewModel

    {

        public int SelectedEntity { get; set; }
        public string table { get; set; }
        public int SelectedKategoriId { get; set; }
        public List<SelectListItem> SelectListTipi { get; set; }
        public List<konfigurime> konfigurimet { get; set; }
        public List<SelectListItem> SelectTipParent { get; set; }
        public SelectAllActiveRec_Entitet_tip_Result EntitetTip { get; set; }
        public List<SelectAllActiveRec_nder_Entitet_tip_kategori_Result> SelectTipKategori { get; set; }
        public List<SelectAllActiveRec_Entitet_tip_Result> EntitetTipList { get; set; }
        public List<Tipe> TipeTree { get; set; }
        public List<SelectListItem> SelectListEntity { get; set; }

    }
}