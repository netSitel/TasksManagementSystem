using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using TasksManagementSystem.Models;
using System.Data.Entity.Core.Objects;

namespace TasksManagementSystem.Repositores.Contracts
{
    public interface IBaseRepository
    {
        int FSHIJALL(string tabela);
        ObjectResult<SelectAllActiveRecByTipInfoId_Entitet_tip_info_ch_Result> SelectAllActiveRecByTipInfoId_Entitet_tip_info_ch(string tabela, string tip_info_id);
        ObjectResult<SelectA_Result> SelectA(string tabela);
        ObjectResult<SelectAllActiveRec_Entitet_Result> SelectAllActiveRec_Entitet(string tabela);
        ObjectResult<SelectAllActiveRec_Entitet_access_Result> SelectAllActiveRec_Entitet_access(string tabela);
        ObjectResult<SelectAllActiveRec_Entitet_info_Result> SelectAllActiveRec_Entitet_info(string tabela);
         ObjectResult<SelectAllActiveRec_Entitet_kategori_Result> SelectAllActiveRec_Entitet_kategori(string tabela);
         ObjectResult<SelectAllActiveRec_Entitet_tip_Result> SelectAllActiveRec_Entitet_tip(string tabela);
         ObjectResult<SelectAllActiveRec_Entitet_tip_info_Result> SelectAllActiveRec_Entitet_tip_info(string tabela);
         ObjectResult<SelectAllActiveRec_Entitet_tip_info_ch_Result> SelectAllActiveRec_Entitet_tip_info_ch(string tabela);
         ObjectResult<SelectAllActiveRec_nder_Entitet_kategori_Result> SelectAllActiveRec_nder_Entitet_kategori(string tabela);
         ObjectResult<SelectAllActiveRec_nder_Entitet_tip_kategori_Result> SelectAllActiveRec_nder_Entitet_tip_kategori(string tabela);
         ObjectResult<SelectAllActiveRecByEmertimi_Entitet_Result> SelectAllActiveRecByEmertimi_Entitet(string tabela, string emertimi);
         ObjectResult<SelectAllActiveRecByEmertimi_Entitet_access_Result> SelectAllActiveRecByEmertimi_Entitet_access(string tabela, string emertimi);
        ObjectResult<SelectAllActiveRecByEmertimi_Entitet_info_Result> SelectAllActiveRecByEmertimi_Entitet_info(string tabela, string emertimi);
        ObjectResult<SelectAllActiveRecByEmertimi_Entitet_kategori_Result> SelectAllActiveRecByEmertimi_Entitet_kategori(string tabela, string emertimi);
        ObjectResult<SelectAllActiveRecByEmertimi_Entitet_tip_Result> SelectAllActiveRecByEmertimi_Entitet_tip(string tabela, string emertimi);
        ObjectResult<SelectAllActiveRecByEmertimi_Entitet_tip_info_Result> SelectAllActiveRecByEmertimi_Entitet_tip_info(string tabela, string emertimi);
        ObjectResult<SelectAllActiveRecByEmertimi_Entitet_tip_info_ch_Result> SelectAllActiveRecByEmertimi_Entitet_tip_info_ch(string tabela, string emertimi);
        ObjectResult<SelectAllActiveRecByEmertimi_nder_Entitet_kategori_Result> SelectAllActiveRecByEmertimi_nder_Entitet_kategori(string tabela, string emertimi);
        ObjectResult<SelectAllActiveRecByEmertimi_nder_Entitet_tip_kategori_Result> SelectAllActiveRecByEmertimi_nder_Entitet_tip_kategori(string tabela, string emertimi);
        ObjectResult<SelectAllActiveRecByEmertimiAndSup_Entitet_Result> SelectAllActiveRecByEmertimiAndSup_Entitet(string tabela, string id_sup, string emertimi);
        ObjectResult<SelectAllActiveRecByEmertimiAndSup_Entitet_access_Result> SelectAllActiveRecByEmertimiAndSup_Entitet_access(string tabela, string id_sup, string emertimi);
        ObjectResult<SelectAllActiveRecByEmertimiAndSup_Entitet_info_Result> SelectAllActiveRecByEmertimiAndSup_Entitet_info(string tabela, string id_sup, string emertimi);
        ObjectResult<SelectAllActiveRecByEmertimiAndSup_Entitet_kategori_Result> SelectAllActiveRecByEmertimiAndSup_Entitet_kategori(string tabela, string id_sup, string emertimi);
        ObjectResult<SelectAllActiveRecByEmertimiAndSup_Entitet_tip_Result> SelectAllActiveRecByEmertimiAndSup_Entitet_tip(string tabela, string id_sup, string emertimi);
        ObjectResult<SelectAllActiveRecByEmertimiAndSup_Entitet_tip_info_Result> SelectAllActiveRecByEmertimiAndSup_Entitet_tip_info(string tabela, string id_sup, string emertimi);
        ObjectResult<SelectAllActiveRecByEmertimiAndSup_Entitet_tip_info_ch_Result> SelectAllActiveRecByEmertimiAndSup_Entitet_tip_info_ch(string tabela, string id_sup, string emertimi);
        ObjectResult<SelectAllActiveRecByEmertimiAndSup_nder_Entitet_kategori_Result> SelectAllActiveRecByEmertimiAndSup_nder_Entitet_kategori(string tabela, string id_sup, string emertimi);
        ObjectResult<SelectAllActiveRecByEmertimiAndSup_nder_Entitet_tip_kategori_Result> SelectAllActiveRecByEmertimiAndSup_nder_Entitet_tip_kategori(string tabela, string id_sup, string emertimi);
        ObjectResult<SelectAllActiveRecByKodi_Entitet_Result> SelectAllActiveRecByKodi_Entitet(string tabela, string kodi);
        ObjectResult<SelectAllActiveRecByKodiAndSup_Entitet_Result> SelectAllActiveRecByKodiAndSup_Entitet(string tabela, string kodi, string id_sup);
        ObjectResult<SelectAllActiveRecBySup_Entitet_Result> SelectAllActiveRecBySup_Entitet(string tabela, string id_sup);
        ObjectResult<SelectAllActiveRecBySup_Entitet_access_Result> SelectAllActiveRecBySup_Entitet_access(string tabela, string id_sup);
        ObjectResult<SelectAllActiveRecBySup_Entitet_info_Result> SelectAllActiveRecBySup_Entitet_info(string tabela, string id_sup);
        ObjectResult<SelectAllActiveRecBySup_Entitet_kategori_Result> SelectAllActiveRecBySup_Entitet_kategori(string tabela, string id_sup);
        ObjectResult<SelectAllActiveRecBySup_Entitet_tip_Result> SelectAllActiveRecBySup_Entitet_tip(string tabela, string id_sup);
        ObjectResult<SelectAllActiveRecBySup_Entitet_tip_info_Result> SelectAllActiveRecBySup_Entitet_tip_info(string tabela, string id_sup);
        ObjectResult<SelectAllActiveRecBySup_Entitet_tip_info_ch_Result> SelectAllActiveRecBySup_Entitet_tip_info_ch(string tabela, string id_sup);
        ObjectResult<SelectAllActiveRecBySup_nder_Entitet_kategori_Result> SelectAllActiveRecBySup_nder_Entitet_kategori(string tabela, string id_sup);
        ObjectResult<SelectAllActiveRecBySup_nder_Entitet_tip_kategori_Result> SelectAllActiveRecBySup_nder_Entitet_tip_kategori(string tabela, string id_sup);
        ObjectResult<SelectAllActiveRecByTipId_Entitet_Result> SelectAllActiveRecByTipId_Entitet(string tabela, string tip_id);
        
    }
}
