using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Web;
using TasksManagementSystem.Models;
using TasksManagementSystem.Repositores.Contracts;

namespace TasksManagementSystem.Repositores
{
    public class BaseRepository : IBaseRepository
    {
        int IBaseRepository.FSHIJALL(string tabela)
        {
            using (var context = new tasketDb())
            {
                var result = context.FSHIJALL(tabela);
                return result;
            }
        }

        public ObjectResult<SelectA_Result> SelectA(string tabela)
        {
            return new tasketDb().SelectA(tabela);
        }

        public ObjectResult<SelectAllActiveRecByEmertimiAndSup_Entitet_Result> SelectAllActiveRecByEmertimiAndSup_Entitet(string tabela, string id_sup, string emertimi)
        {
            return new tasketDb().SelectAllActiveRecByEmertimiAndSup_Entitet(tabela, id_sup,emertimi);
        }

        public ObjectResult<SelectAllActiveRecByEmertimiAndSup_Entitet_access_Result> SelectAllActiveRecByEmertimiAndSup_Entitet_access(string tabela, string id_sup, string emertimi)
        {
            return new tasketDb().SelectAllActiveRecByEmertimiAndSup_Entitet_access(tabela, id_sup,emertimi);
        }

        public ObjectResult<SelectAllActiveRecByEmertimiAndSup_Entitet_info_Result> SelectAllActiveRecByEmertimiAndSup_Entitet_info(string tabela, string id_sup, string emertimi)
        {
            return new tasketDb().SelectAllActiveRecByEmertimiAndSup_Entitet_info(tabela, id_sup,emertimi);
        }

        public ObjectResult<SelectAllActiveRecByEmertimiAndSup_Entitet_kategori_Result> SelectAllActiveRecByEmertimiAndSup_Entitet_kategori(string tabela, string id_sup, string emertimi)
        {
            return new tasketDb().SelectAllActiveRecByEmertimiAndSup_Entitet_kategori(tabela, id_sup,emertimi);
        }

        public ObjectResult<SelectAllActiveRecByEmertimiAndSup_Entitet_tip_Result> SelectAllActiveRecByEmertimiAndSup_Entitet_tip(string tabela, string id_sup, string emertimi)
        {
            return new tasketDb().SelectAllActiveRecByEmertimiAndSup_Entitet_tip(tabela, id_sup,emertimi);
        }

        public ObjectResult<SelectAllActiveRecByEmertimiAndSup_Entitet_tip_info_Result> SelectAllActiveRecByEmertimiAndSup_Entitet_tip_info(string tabela, string id_sup, string emertimi)
        {
            return new tasketDb().SelectAllActiveRecByEmertimiAndSup_Entitet_tip_info(tabela, id_sup,emertimi);
        }

        public ObjectResult<SelectAllActiveRecByEmertimiAndSup_Entitet_tip_info_ch_Result> SelectAllActiveRecByEmertimiAndSup_Entitet_tip_info_ch(string tabela, string id_sup, string emertimi)
        {
            return new tasketDb().SelectAllActiveRecByEmertimiAndSup_Entitet_tip_info_ch(tabela, id_sup,emertimi);
        }

        public ObjectResult<SelectAllActiveRecByEmertimiAndSup_nder_Entitet_kategori_Result> SelectAllActiveRecByEmertimiAndSup_nder_Entitet_kategori(string tabela, string id_sup, string emertimi)
        {
            return new tasketDb().SelectAllActiveRecByEmertimiAndSup_nder_Entitet_kategori(tabela, id_sup,emertimi);
        }

        public ObjectResult<SelectAllActiveRecByEmertimiAndSup_nder_Entitet_tip_kategori_Result> SelectAllActiveRecByEmertimiAndSup_nder_Entitet_tip_kategori(string tabela, string id_sup, string emertimi)
        {
            return new tasketDb().SelectAllActiveRecByEmertimiAndSup_nder_Entitet_tip_kategori(tabela, id_sup,emertimi);
        }

        public ObjectResult<SelectAllActiveRecByEmertimi_Entitet_Result> SelectAllActiveRecByEmertimi_Entitet(string tabela, string emertimi)
        {
            return new tasketDb().SelectAllActiveRecByEmertimi_Entitet(tabela, emertimi);
        }

        public ObjectResult<SelectAllActiveRecByEmertimi_Entitet_access_Result> SelectAllActiveRecByEmertimi_Entitet_access(string tabela, string emertimi)
        {
            return new tasketDb().SelectAllActiveRecByEmertimi_Entitet_access(tabela, emertimi);
        }

        public ObjectResult<SelectAllActiveRecByEmertimi_Entitet_info_Result> SelectAllActiveRecByEmertimi_Entitet_info(string tabela, string emertimi)
        {
            return new tasketDb().SelectAllActiveRecByEmertimi_Entitet_info(tabela, emertimi);
        }

        public ObjectResult<SelectAllActiveRecByEmertimi_Entitet_kategori_Result> SelectAllActiveRecByEmertimi_Entitet_kategori(string tabela, string emertimi)
        {
            return new tasketDb().SelectAllActiveRecByEmertimi_Entitet_kategori(tabela, emertimi);
        }

        public ObjectResult<SelectAllActiveRecByEmertimi_Entitet_tip_Result> SelectAllActiveRecByEmertimi_Entitet_tip(string tabela, string emertimi)
        {
            return new tasketDb().SelectAllActiveRecByEmertimi_Entitet_tip(tabela, emertimi);
        }

        public ObjectResult<SelectAllActiveRecByEmertimi_Entitet_tip_info_Result> SelectAllActiveRecByEmertimi_Entitet_tip_info(string tabela, string emertimi)
        {
            return new tasketDb().SelectAllActiveRecByEmertimi_Entitet_tip_info(tabela, emertimi);
        }

        public ObjectResult<SelectAllActiveRecByEmertimi_Entitet_tip_info_ch_Result> SelectAllActiveRecByEmertimi_Entitet_tip_info_ch(string tabela, string emertimi)
        {
            return new tasketDb().SelectAllActiveRecByEmertimi_Entitet_tip_info_ch(tabela, emertimi);
        }

        public ObjectResult<SelectAllActiveRecByEmertimi_nder_Entitet_kategori_Result> SelectAllActiveRecByEmertimi_nder_Entitet_kategori(string tabela, string emertimi)
        {
            return new tasketDb().SelectAllActiveRecByEmertimi_nder_Entitet_kategori(tabela, emertimi);
        }

        public ObjectResult<SelectAllActiveRecByEmertimi_nder_Entitet_tip_kategori_Result> SelectAllActiveRecByEmertimi_nder_Entitet_tip_kategori(string tabela, string emertimi)
        {
            return new tasketDb().SelectAllActiveRecByEmertimi_nder_Entitet_tip_kategori(tabela, emertimi);
        }

        public ObjectResult<SelectAllActiveRecByKodiAndSup_Entitet_Result> SelectAllActiveRecByKodiAndSup_Entitet(string tabela, string kodi, string id_sup)
        {
            return new tasketDb().SelectAllActiveRecByKodiAndSup_Entitet(tabela, kodi,id_sup);
        }

        public ObjectResult<SelectAllActiveRecByKodi_Entitet_Result> SelectAllActiveRecByKodi_Entitet(string tabela, string kodi)
        {
            return new tasketDb().SelectAllActiveRecByKodi_Entitet(tabela, kodi);
        }

        public ObjectResult<SelectAllActiveRecByNrrendor_Entitet_Result> SelectAllActiveRecByNrrendor_Entitet(string tabela, string nrrendor)
        {
            return new tasketDb().SelectAllActiveRecByNrrendor_Entitet(tabela, nrrendor);
        }

        public ObjectResult<SelectAllActiveRecByNrrendor_Entitet_access_Result> SelectAllActiveRecByNrrendor_Entitet_access(string tabela, string nrrendor)
        {
            return new tasketDb().SelectAllActiveRecByNrrendor_Entitet_access(tabela, nrrendor);
        }

        public ObjectResult<SelectAllActiveRecByNrrendor_Entitet_info_Result> SelectAllActiveRecByNrrendor_Entitet_info(string tabela, string nrrendor)
        {
            return new tasketDb().SelectAllActiveRecByNrrendor_Entitet_info(tabela, nrrendor);
        }

        public ObjectResult<SelectAllActiveRecByNrrendor_Entitet_kategori_Result> SelectAllActiveRecByNrrendor_Entitet_kategori(string tabela, string nrrendor)
        {
            return new tasketDb().SelectAllActiveRecByNrrendor_Entitet_kategori(tabela, nrrendor);
        }

        public ObjectResult<SelectAllActiveRecByNrrendor_Entitet_tip_Result> SelectAllActiveRecByNrrendor_Entitet_tip(string tabela, string nrrendor)
        {
            return new tasketDb().SelectAllActiveRecByNrrendor_Entitet_tip(tabela, nrrendor);
        }

        public ObjectResult<SelectAllActiveRecByNrrendor_Entitet_tip_info_Result> SelectAllActiveRecByNrrendor_Entitet_tip_info(string tabela, string nrrendor)
        {
            return new tasketDb().SelectAllActiveRecByNrrendor_Entitet_tip_info(tabela, nrrendor);
        }

        public ObjectResult<SelectAllActiveRecByNrrendor_Entitet_tip_info_ch_Result> SelectAllActiveRecByNrrendor_Entitet_tip_info_ch(string tabela, string nrrendor)
        {
            return new tasketDb().SelectAllActiveRecByNrrendor_Entitet_tip_info_ch(tabela, nrrendor);
        }

        public ObjectResult<SelectAllActiveRecByNrrendor_nder_Entitet_kategori_Result> SelectAllActiveRecByNrrendor_nder_Entitet_kategori(string tabela, string nrrendor)
        {
            return new tasketDb().SelectAllActiveRecByNrrendor_nder_Entitet_kategori(tabela, nrrendor);
        }

        public ObjectResult<SelectAllActiveRecByNrrendor_nder_Entitet_tip_kategori_Result> SelectAllActiveRecByNrrendor_nder_Entitet_tip_kategori(string tabela, string nrrendor)
        {
            return new tasketDb().SelectAllActiveRecByNrrendor_nder_Entitet_tip_kategori(tabela, nrrendor);
        }

        public ObjectResult<SelectAllActiveRecBySup_Entitet_Result> SelectAllActiveRecBySup_Entitet(string tabela, string id_sup)
        {
            return new tasketDb().SelectAllActiveRecBySup_Entitet(tabela, id_sup);
        }

        public ObjectResult<SelectAllActiveRecBySup_Entitet_access_Result> SelectAllActiveRecBySup_Entitet_access(string tabela, string id_sup)
        {
            return new tasketDb().SelectAllActiveRecBySup_Entitet_access(tabela, id_sup);
        }

        public ObjectResult<SelectAllActiveRecBySup_Entitet_info_Result> SelectAllActiveRecBySup_Entitet_info(string tabela, string id_sup)
        {
            return new tasketDb().SelectAllActiveRecBySup_Entitet_info(tabela, id_sup);
        }

        public ObjectResult<SelectAllActiveRecBySup_Entitet_kategori_Result> SelectAllActiveRecBySup_Entitet_kategori(string tabela, string id_sup)
        {
            return new tasketDb().SelectAllActiveRecBySup_Entitet_kategori(tabela, id_sup);
        }

        public ObjectResult<SelectAllActiveRecBySup_Entitet_tip_Result> SelectAllActiveRecBySup_Entitet_tip(string tabela, string id_sup)
        {
            return new tasketDb().SelectAllActiveRecBySup_Entitet_tip(tabela, id_sup);
        }

        public ObjectResult<SelectAllActiveRecBySup_Entitet_tip_info_Result> SelectAllActiveRecBySup_Entitet_tip_info(string tabela, string id_sup)
        {
            return new tasketDb().SelectAllActiveRecBySup_Entitet_tip_info(tabela, id_sup);
        }

        public ObjectResult<SelectAllActiveRecBySup_Entitet_tip_info_ch_Result> SelectAllActiveRecBySup_Entitet_tip_info_ch(string tabela, string id_sup)
        {
            return new tasketDb().SelectAllActiveRecBySup_Entitet_tip_info_ch(tabela, id_sup);
        }

        public ObjectResult<SelectAllActiveRecBySup_nder_Entitet_kategori_Result> SelectAllActiveRecBySup_nder_Entitet_kategori(string tabela, string id_sup)
        {
            return new tasketDb().SelectAllActiveRecBySup_nder_Entitet_kategori(tabela, id_sup);
        }

        public ObjectResult<SelectAllActiveRecBySup_nder_Entitet_tip_kategori_Result> SelectAllActiveRecBySup_nder_Entitet_tip_kategori(string tabela, string id_sup)
        {
            return new tasketDb().SelectAllActiveRecBySup_nder_Entitet_tip_kategori(tabela, id_sup);
        }





        public ObjectResult<SelectAllActiveRecByTipId_Entitet_Result> SelectAllActiveRecByTipId_Entitet(string tabela, string tip_id)
        {
            return new tasketDb().SelectAllActiveRecByTipId_Entitet(tabela, tip_id);
        }



        public ObjectResult<SelectAllActiveRecByTipInfoId_Entitet_tip_info_ch_Result> SelectAllActiveRecByTipInfoId_Entitet_tip_info_ch(string tabela, string tip_info_id)
        {
            return new tasketDb().SelectAllActiveRecByTipInfoId_Entitet_tip_info_ch(tabela,tip_info_id);
        }

        public ObjectResult<SelectAllActiveRec_Entitet_Result> SelectAllActiveRec_Entitet(string tabela)
        {
            return new tasketDb().SelectAllActiveRec_Entitet(tabela);
        }

        public ObjectResult<SelectAllActiveRec_Entitet_access_Result> SelectAllActiveRec_Entitet_access(string tabela)
        {
            return new tasketDb().SelectAllActiveRec_Entitet_access(tabela);
        }

        public ObjectResult<SelectAllActiveRec_Entitet_info_Result> SelectAllActiveRec_Entitet_info(string tabela)
        {
            return new tasketDb().SelectAllActiveRec_Entitet_info(tabela);

        }
        public ObjectResult<SelectAllActiveRec_Entitet_kategori_Result> SelectAllActiveRec_Entitet_kategori(string tabela)
        {
            //var context = new tasketDb();

            //    var result = context.SelectAllActiveRec_Entitet_kategori(tabela);
            //    return result;
            return new tasketDb().SelectAllActiveRec_Entitet_kategori(tabela);


        }

        public ObjectResult<SelectAllActiveRec_Entitet_tip_Result> SelectAllActiveRec_Entitet_tip(string tabela)
        {
            return new tasketDb().SelectAllActiveRec_Entitet_tip(tabela);
        }

        public ObjectResult<SelectAllActiveRec_Entitet_tip_info_Result> SelectAllActiveRec_Entitet_tip_info(string tabela)
        {
            return new tasketDb().SelectAllActiveRec_Entitet_tip_info(tabela);
        }

        public ObjectResult<SelectAllActiveRec_Entitet_tip_info_ch_Result> SelectAllActiveRec_Entitet_tip_info_ch(string tabela)
        {
            return new tasketDb().SelectAllActiveRec_Entitet_tip_info_ch(tabela);

        }

        public ObjectResult<SelectAllActiveRec_nder_Entitet_kategori_Result> SelectAllActiveRec_nder_Entitet_kategori(string tabela)
        {
            return new tasketDb().SelectAllActiveRec_nder_Entitet_kategori(tabela);
        }

        public ObjectResult<SelectAllActiveRec_nder_Entitet_tip_kategori_Result> SelectAllActiveRec_nder_Entitet_tip_kategori(string tabela)
        {
            return new tasketDb().SelectAllActiveRec_nder_Entitet_tip_kategori(tabela);
        }
    }
}