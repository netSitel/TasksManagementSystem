//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TasksManagementSystem.Models
{
    using System;
    
    public partial class SelectAllActiveRecBySup_nder_Entitet_kategori_Result
    {
        public int nrrendor { get; set; }
        public string id_gen { get; set; }
        public Nullable<int> id_sup { get; set; }
        public string id_sup_gen { get; set; }
        public Nullable<int> id_ndr { get; set; }
        public string id_ndr_gen { get; set; }
        public Nullable<int> Entitet_id { get; set; }
        public string Entitet_id_gen { get; set; }
        public Nullable<int> Entitet_kategori_id { get; set; }
        public string Entitet_kategori_id_gen { get; set; }
        public bool aktiv { get; set; }
        public System.DateTime data_krijimit { get; set; }
        public Nullable<int> perdorues_id { get; set; }
        public string perdorues_id_gen { get; set; }
    }
}
