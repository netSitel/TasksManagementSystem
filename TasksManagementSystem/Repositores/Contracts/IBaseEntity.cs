using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksManagementSystem.Repositores.Contracts
{
    public interface IBaseEntity
    {
         int InsertEntity (Nullable<int> id_sup, Nullable<int> tip_id, string kodi, string emertimi, string pershkrimi, string emertimiang, string pershkrimiang, Nullable<int> perdorues_id, Nullable<int> kategoria, Nullable<bool> kompleks);
        int InsertEntity_access(string id_gen, Nullable<int> id_sup, string id_sup_gen, Nullable<int> id_ndr, string id_ndr_gen, Nullable<int> analize_id, string analize_id_gen, Nullable<int> perdoruesi_id, string perdoruesi_id_gen, Nullable<bool> aktiv, Nullable<System.DateTime> data_krijimit, Nullable<int> perdorues_id, string perdorues_id_gen);
        int InsertEntity_info(Nullable<int> id_sup, Nullable<int> element_id, Nullable<int> tip_info_id, string emertimi, string pershkrimi, string emertimiang, string pershkrimiang, Nullable<int> perdorues_id);
        int InsertEntity_kategori(Nullable<int> id_sup, Nullable<bool> elcat, string kodi, string emertimi, string pershkrimi, string emertimiang, string pershkrimiang, Nullable<double> rradha, Nullable<int> perdorues_id);
        int InsertEntity_tip(Nullable<int> id_sup, Nullable<bool> elcat, string kodi, Nullable<int> kodifillim, Nullable<int> kodimbarim, Nullable<int> kodiaktual, string emertimi, string pershkrimi, string emertimiang, string pershkrimiang, Nullable<double> rradha, Nullable<int> perdorues_id);
        int InsertEntity_tip_info(Nullable<int> id_sup, Nullable<int> tip_id, string emertimi, string pershkrimi, string emertimiang, string pershkrimiang, Nullable<int> veti, Nullable<bool> detyrueshme, Nullable<double> rradha, Nullable<int> db, Nullable<bool> skedar, Nullable<int> perdorues_id);
        int InsertEntity_tip_info_ch(Nullable<int> id_sup, Nullable<int> tip_info_id, string emertimi, string pershkrimi, string emertimiang, string pershkrimiang, Nullable<int> perdorues_id, Nullable<bool> vA);



        int UpdateEntity(Nullable<int> nrrendor, Nullable<int> id_sup, Nullable<bool> considerNull_id_sup, Nullable<int> tip_id, Nullable<bool> considerNull_tip_id, string kodi, Nullable<bool> considerNull_kodi, string emertimi, Nullable<bool> considerNull_Emertimi, string pershkrimi, Nullable<bool> considerNull_pershkrimi, string emertimiang, Nullable<bool> considerNull_Emertimiang, string pershkrimiang, Nullable<bool> considerNull_pershkrimiang, Nullable<bool> aktiv, Nullable<bool> considerNull_Aktiv, Nullable<int> perdorues_id, Nullable<bool> considerNull_Perdorues_id, Nullable<bool> kompleks, Nullable<bool> considerNull_kompleks);
        int UpdateEntity_access(Nullable<int> analize_id, Nullable<int> perdoruesi_id);
        int UpdateEntity_info(Nullable<int> nrrendor, Nullable<int> id_sup, Nullable<bool> considerNull_id_sup, Nullable<int> element_id, Nullable<bool> considerNull_element_id, Nullable<int> tip_info_id, Nullable<bool> considerNull_tip_info_id, string emertimi, Nullable<bool> considerNull_Emertimi, string pershkrimi, Nullable<bool> considerNull_pershkrimi, string emertimiang, Nullable<bool> considerNull_Emertimiang, string pershkrimiang, Nullable<bool> considerNull_pershkrimiang, Nullable<bool> aktiv, Nullable<bool> considerNull_Aktiv, Nullable<int> perdorues_id, Nullable<bool> considerNull_Perdorues_id);
        int UpdateEntity_kategori(Nullable<int> nrrendor, Nullable<int> id_sup, Nullable<bool> considerNull_id_sup, Nullable<int> elcat, Nullable<bool> considerNull_elcat, string kodi, Nullable<bool> considerNull_kodi, string emertimi, Nullable<bool> considerNull_Emertimi, string pershkrimi, Nullable<bool> considerNull_pershkrimi, string emertimiang, Nullable<bool> considerNull_Emertimiang, string pershkrimiang, Nullable<bool> considerNull_pershkrimiang, Nullable<bool> aktiv, Nullable<bool> considerNull_Aktiv, Nullable<int> perdorues_id, Nullable<bool> considerNull_Perdorues_id);
        int UpdateEntity_tip(Nullable<int> nrrendor, Nullable<int> id_sup, Nullable<bool> considerNull_id_sup, Nullable<int> elcat, Nullable<bool> considerNull_elcat, string kodi, Nullable<bool> considerNull_kodi, Nullable<int> kodifillim, Nullable<bool> considerNull_kodifillim, Nullable<int> kodiaktual, Nullable<bool> considerNull_kodiaktual, Nullable<int> kodimbarim, Nullable<bool> considerNull_kodimbarim, string emertimi, Nullable<bool> considerNull_Emertimi, string pershkrimi, Nullable<bool> considerNull_pershkrimi, string emertimiang, Nullable<bool> considerNull_Emertimiang, string pershkrimiang, Nullable<bool> considerNull_pershkrimiang, Nullable<bool> aktiv, Nullable<bool> considerNull_Aktiv, Nullable<int> perdorues_id, Nullable<bool> considerNull_Perdorues_id);
        int UpdateEntity_tip_info(Nullable<int> nrrendor, Nullable<int> id_sup, Nullable<bool> considerNull_id_sup, Nullable<int> tip_id, Nullable<bool> considerNull_tip_id, string emertimi, Nullable<bool> considerNull_Emertimi, string pershkrimi, Nullable<bool> considerNull_pershkrimi, string emertimiang, Nullable<bool> considerNull_Emertimiang, string pershkrimiang, Nullable<bool> considerNull_pershkrimiang, Nullable<int> veti, Nullable<bool> considerNull_veti, Nullable<bool> skedar, Nullable<bool> considerNull_skedar, Nullable<bool> detyrueshme, Nullable<bool> considerNull_detyrueshme, Nullable<double> rradha, Nullable<bool> considerNull_Rradha, Nullable<bool> aktiv, Nullable<bool> considerNull_Aktiv, Nullable<int> perdorues_id, Nullable<bool> considerNull_Perdorues_id);
        int UpdateEntity_tip_info_ch(Nullable<int> nrrendor, Nullable<int> id_sup, Nullable<bool> considerNull_id_sup, Nullable<int> tip_info_id, Nullable<bool> considerNull_tip_info_id, string emertimi, Nullable<bool> considerNull_Emertimi, string pershkrimi, Nullable<bool> considerNull_pershkrimi, string emertimiang, Nullable<bool> considerNull_Emertimiang, string pershkrimiang, Nullable<bool> considerNull_pershkrimiang, Nullable<bool> aktiv, Nullable<bool> considerNull_Aktiv, Nullable<int> perdorues_id, Nullable<bool> considerNull_Perdorues_id);



    }
}
