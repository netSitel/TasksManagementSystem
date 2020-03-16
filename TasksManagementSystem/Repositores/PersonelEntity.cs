using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TasksManagementSystem.Models;
using TasksManagementSystem.Repositores.Contracts;

namespace TasksManagementSystem.Repositores
{
    public class PersonelEntity:IBaseEntity
    {
        int IBaseEntity.InsertEntity(int? id_sup, int? tip_id, string kodi, string emertimi, string pershkrimi, string emertimiang, string pershkrimiang, int? perdorues_id, int? kategoria, bool? kompleks)
        {
            using (var context = new taskDb())
            {

                var result = context.spI_tbl_personel(id_sup, tip_id, kodi, emertimi, pershkrimi, emertimiang, pershkrimiang, perdorues_id, kategoria, kompleks);
                return result;
            }

        }

        int IBaseEntity.InsertEntity_access(string id_gen, int? id_sup, string id_sup_gen, int? id_ndr, string id_ndr_gen, int? personel_id, string personel_id_gen, int? perdoruesi_id, string perdoruesi_id_gen, bool? aktiv, DateTime? data_krijimit, int? perdorues_id, string perdorues_id_gen)
        {
            using (var context = new taskDb())
            {

                var result = context.spI_tbl_personel_access(id_gen, id_sup, id_sup_gen, id_ndr, id_ndr_gen, personel_id, personel_id_gen, perdoruesi_id, perdoruesi_id_gen, aktiv, data_krijimit, perdorues_id, perdorues_id_gen);
                return result;
            }
        }

        int IBaseEntity.InsertEntity_info(int? id_sup, int? element_id, int? tip_info_id, string emertimi, string pershkrimi, string emertimiang, string pershkrimiang, int? perdorues_id)
        {
            using (var context = new taskDb())
            {

                var result = context.spI_tbl_personel_info(id_sup, element_id, tip_info_id, emertimi, pershkrimi, emertimiang, pershkrimiang, perdorues_id);
                return result;
            }
        }

        int IBaseEntity.InsertEntity_kategori(int? id_sup, bool? elcat, string kodi, string emertimi, string pershkrimi, string emertimiang, string pershkrimiang, double? rradha, int? perdorues_id)
        {
            using (var context = new taskDb())
            {

                var result = context.spI_tbl_personel_kategori(id_sup, elcat, kodi, emertimi, pershkrimi, emertimiang, pershkrimiang, rradha, perdorues_id);
                return result;
            }
        }

        int IBaseEntity.InsertEntity_tip(int? id_sup, bool? elcat, string kodi, int? kodifillim, int? kodimbarim, int? kodiaktual, string emertimi, string pershkrimi, string emertimiang, string pershkrimiang, double? rradha, int? perdorues_id)
        {
            using (var context = new taskDb())
            {

                var result = context.spI_tbl_personel_tip(id_sup, elcat, kodi, kodifillim, kodimbarim, kodiaktual, emertimi, pershkrimi, emertimiang, pershkrimiang, rradha, perdorues_id);
                return result;
            }
        }

        int IBaseEntity.InsertEntity_tip_info(int? id_sup, int? tip_id, string emertimi, string pershkrimi, string emertimiang, string pershkrimiang, int? veti, bool? detyrueshme, double? rradha, int? db, bool? skedar, int? perdorues_id)
        {
            using (var context = new taskDb())
            {

                var result = context.spI_tbl_personel_tip_info(id_sup, tip_id, emertimi, pershkrimi, emertimiang, pershkrimiang, veti, detyrueshme, rradha, db, skedar, perdorues_id);
                return result;
            }
        }

        int IBaseEntity.InsertEntity_tip_info_ch(int? id_sup, int? tip_info_id, string emertimi, string pershkrimi, string emertimiang, string pershkrimiang, int? perdorues_id, bool? vA)
        {
            using (var context = new taskDb())
            {

                var result = context.spI_tbl_personel_tip_info_ch(id_sup, tip_info_id, emertimi, pershkrimi, emertimiang, pershkrimiang, perdorues_id, vA);
                return result;
            }
        }

        int IBaseEntity.UpdateEntity(int? nrrendor, int? id_sup, bool? considerNull_id_sup, int? tip_id, bool? considerNull_tip_id, string kodi, bool? considerNull_kodi, string emertimi, bool? considerNull_Emertimi, string pershkrimi, bool? considerNull_pershkrimi, string emertimiang, bool? considerNull_Emertimiang, string pershkrimiang, bool? considerNull_pershkrimiang, bool? aktiv, bool? considerNull_Aktiv, int? perdorues_id, bool? considerNull_Perdorues_id, bool? kompleks, bool? considerNull_kompleks)
        {
            using (var context = new taskDb())
            {

                var result = context.spU_tbl_personel(nrrendor, id_sup, considerNull_id_sup, tip_id, considerNull_tip_id, kodi, considerNull_kodi, emertimi, considerNull_Emertimi, pershkrimi, considerNull_pershkrimi, emertimiang, considerNull_Emertimiang, pershkrimiang, considerNull_pershkrimiang, aktiv, considerNull_Aktiv, perdorues_id, considerNull_Perdorues_id, kompleks, considerNull_kompleks);
                return result;
            }
        }
        int IBaseEntity.UpdateEntity_access(int? personel_id, int? perdoruesi_id)
        {
            using (var context = new taskDb())
            {

                var result = context.spU_tbl_personel_access(personel_id, perdoruesi_id);
                return result;
            }
        }

        int IBaseEntity.UpdateEntity_info(int? nrrendor, int? id_sup, bool? considerNull_id_sup, int? element_id, bool? considerNull_element_id, int? tip_info_id, bool? considerNull_tip_info_id, string emertimi, bool? considerNull_Emertimi, string pershkrimi, bool? considerNull_pershkrimi, string emertimiang, bool? considerNull_Emertimiang, string pershkrimiang, bool? considerNull_pershkrimiang, bool? aktiv, bool? considerNull_Aktiv, int? perdorues_id, bool? considerNull_Perdorues_id)
        {
            using (var context = new taskDb())
            {

                var result = context.spU_tbl_personel_info(nrrendor, id_sup, considerNull_id_sup, element_id, considerNull_element_id, tip_info_id, considerNull_tip_info_id, emertimi, considerNull_Emertimi, pershkrimi, considerNull_pershkrimi, emertimiang, considerNull_Emertimiang, pershkrimiang, considerNull_pershkrimiang, aktiv, considerNull_Aktiv, perdorues_id, considerNull_Perdorues_id);
                return result;
            }
        }

        int IBaseEntity.UpdateEntity_kategori(int? nrrendor, int? id_sup, bool? considerNull_id_sup, int? elcat, bool? considerNull_elcat, string kodi, bool? considerNull_kodi, string emertimi, bool? considerNull_Emertimi, string pershkrimi, bool? considerNull_pershkrimi, string emertimiang, bool? considerNull_Emertimiang, string pershkrimiang, bool? considerNull_pershkrimiang, bool? aktiv, bool? considerNull_Aktiv, int? perdorues_id, bool? considerNull_Perdorues_id)
        {
            using (var context = new taskDb())
            {

                var result = context.spU_tbl_personel_kategori(nrrendor, id_sup, considerNull_id_sup, elcat, considerNull_elcat, kodi, considerNull_kodi, emertimi, considerNull_Emertimi, pershkrimi, considerNull_pershkrimi, emertimiang, considerNull_Emertimiang, pershkrimiang, considerNull_pershkrimiang, aktiv, considerNull_Aktiv, perdorues_id, considerNull_Perdorues_id);
                return result;
            }
        }

        int IBaseEntity.UpdateEntity_tip(int? nrrendor, int? id_sup, bool? considerNull_id_sup, int? elcat, bool? considerNull_elcat, string kodi, bool? considerNull_kodi, int? kodifillim, bool? considerNull_kodifillim, int? kodiaktual, bool? considerNull_kodiaktual, int? kodimbarim, bool? considerNull_kodimbarim, string emertimi, bool? considerNull_Emertimi, string pershkrimi, bool? considerNull_pershkrimi, string emertimiang, bool? considerNull_Emertimiang, string pershkrimiang, bool? considerNull_pershkrimiang, bool? aktiv, bool? considerNull_Aktiv, int? perdorues_id, bool? considerNull_Perdorues_id)
        {
            using (var context = new taskDb())
            {

                var result = context.spU_tbl_personel_tip(nrrendor, id_sup, considerNull_id_sup, elcat, considerNull_elcat, kodi, considerNull_kodi, kodifillim, considerNull_kodifillim, kodiaktual, considerNull_kodiaktual, kodimbarim, considerNull_kodimbarim, emertimi, considerNull_Emertimi, pershkrimi, considerNull_pershkrimi, emertimiang, considerNull_Emertimiang, pershkrimiang, considerNull_pershkrimiang, aktiv, considerNull_Aktiv, perdorues_id, considerNull_Perdorues_id);

                return result;
            }
        }

        int IBaseEntity.UpdateEntity_tip_info(int? nrrendor, int? id_sup, bool? considerNull_id_sup, int? tip_id, bool? considerNull_tip_id, string emertimi, bool? considerNull_Emertimi, string pershkrimi, bool? considerNull_pershkrimi, string emertimiang, bool? considerNull_Emertimiang, string pershkrimiang, bool? considerNull_pershkrimiang, int? veti, bool? considerNull_veti, bool? skedar, bool? considerNull_skedar, bool? detyrueshme, bool? considerNull_detyrueshme, double? rradha, bool? considerNull_Rradha, bool? aktiv, bool? considerNull_Aktiv, int? perdorues_id, bool? considerNull_Perdorues_id)
        {
            using (var context = new taskDb())
            {

                var result = context.spU_tbl_personel_tip_info(nrrendor, id_sup, considerNull_id_sup, tip_id, considerNull_tip_id, emertimi, considerNull_Emertimi, pershkrimi, considerNull_pershkrimi, emertimiang, considerNull_Emertimiang, pershkrimiang, considerNull_pershkrimiang, veti, considerNull_veti, skedar, considerNull_skedar, detyrueshme, considerNull_detyrueshme, rradha, considerNull_Rradha, aktiv, considerNull_Aktiv, perdorues_id, considerNull_Perdorues_id);
                return result;
            }
        }

        int IBaseEntity.UpdateEntity_tip_info_ch(int? nrrendor, int? id_sup, bool? considerNull_id_sup, int? tip_info_id, bool? considerNull_tip_info_id, string emertimi, bool? considerNull_Emertimi, string pershkrimi, bool? considerNull_pershkrimi, string emertimiang, bool? considerNull_Emertimiang, string pershkrimiang, bool? considerNull_pershkrimiang, bool? aktiv, bool? considerNull_Aktiv, int? perdorues_id, bool? considerNull_Perdorues_id)
        {
            using (var context = new taskDb())
            {

                var result = context.spU_tbl_personel_tip_info_ch(nrrendor, id_sup, considerNull_id_sup, tip_info_id, considerNull_tip_info_id, emertimi, considerNull_Emertimi, pershkrimi, considerNull_pershkrimi, emertimiang, considerNull_Emertimiang, pershkrimiang, considerNull_pershkrimiang, aktiv, considerNull_Aktiv, perdorues_id, considerNull_Perdorues_id);
                return result;
            }
        }

    }
}