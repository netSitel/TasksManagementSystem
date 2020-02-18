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
            using (var context = new tasketEntities1())
            {
                var result = context.FSHIJALL(tabela);
                return result;
            }
        }

        ObjectResult<SelectA_Result> IBaseRepository.SelectA(string tabela)
        {
            using (var context = new tasketEntities1())
            {
                var result = context.SelectA(tabela);
                return result;
            }
        }

        

       

        ObjectResult<SelectAllActiveRecByEmertimiAndSup_Entitet_Result> IBaseRepository.SelectAllActiveRecByEmertimiAndSup_Entitet(string tabela, string id_sup, string emertimi)
        {
            using (var context = new tasketEntities1())
            {
                var result = context.SelectAllActiveRecByEmertimiAndSup_Entitet(tabela,id_sup,emertimi);
                return result;
            }
        }

        ObjectResult<SelectAllActiveRecByEmertimiAndSup_Entitet_access_Result> IBaseRepository.SelectAllActiveRecByEmertimiAndSup_Entitet_access(string tabela, string id_sup, string emertimi)
        {
            using (var context = new tasketEntities1())
            {
                var result = context.SelectAllActiveRecByEmertimiAndSup_Entitet_access(tabela, id_sup, emertimi);
                return result;
            }
        }

        ObjectResult<SelectAllActiveRecByEmertimiAndSup_Entitet_info_Result> IBaseRepository.SelectAllActiveRecByEmertimiAndSup_Entitet_info(string tabela, string id_sup, string emertimi)
        {
            using (var context = new tasketEntities1())
            {
                var result = context.SelectAllActiveRecByEmertimiAndSup_Entitet_info(tabela, id_sup, emertimi);
                return result;
            }
        }

        ObjectResult<SelectAllActiveRecByEmertimiAndSup_Entitet_kategori_Result> IBaseRepository.SelectAllActiveRecByEmertimiAndSup_Entitet_kategori(string tabela, string id_sup, string emertimi)
        {
            using (var context = new tasketEntities1())
            {
                var result = context.SelectAllActiveRecByEmertimiAndSup_Entitet_kategori(tabela, id_sup, emertimi);
                return result;
            }
        }

        ObjectResult<SelectAllActiveRecByEmertimiAndSup_Entitet_tip_Result> IBaseRepository.SelectAllActiveRecByEmertimiAndSup_Entitet_tip(string tabela, string id_sup, string emertimi)
        {
            using (var context = new tasketEntities1())
            {
                var result = context.SelectAllActiveRecByEmertimiAndSup_Entitet_tip(tabela, id_sup, emertimi);
                return result;
            }
        }

        ObjectResult<SelectAllActiveRecByEmertimiAndSup_Entitet_tip_info_Result> IBaseRepository.SelectAllActiveRecByEmertimiAndSup_Entitet_tip_info(string tabela, string id_sup, string emertimi)
        {
            using (var context = new tasketEntities1())
            {
                var result = context.SelectAllActiveRecByEmertimiAndSup_Entitet_tip_info(tabela, id_sup, emertimi);
                return result;
            }
        }

        ObjectResult<SelectAllActiveRecByEmertimiAndSup_Entitet_tip_info_ch_Result> IBaseRepository.SelectAllActiveRecByEmertimiAndSup_Entitet_tip_info_ch(string tabela, string id_sup, string emertimi)
        {
            using (var context = new tasketEntities1())
            {
                var result = context.SelectAllActiveRecByEmertimiAndSup_Entitet_tip_info_ch(tabela, id_sup, emertimi);
                return result;
            }
        }

        ObjectResult<SelectAllActiveRecByEmertimiAndSup_nder_Entitet_kategori_Result> IBaseRepository.SelectAllActiveRecByEmertimiAndSup_nder_Entitet_kategori(string tabela, string id_sup, string emertimi)
        {
            using (var context = new tasketEntities1())
            {
                var result = context.SelectAllActiveRecByEmertimiAndSup_nder_Entitet_kategori(tabela, id_sup, emertimi);
                return result;
            }
        }

        ObjectResult<SelectAllActiveRecByEmertimiAndSup_nder_Entitet_tip_kategori_Result> IBaseRepository.SelectAllActiveRecByEmertimiAndSup_nder_Entitet_tip_kategori(string tabela, string id_sup, string emertimi)
        {
            using (var context = new tasketEntities1())
            {
                var result = context.SelectAllActiveRecByEmertimiAndSup_nder_Entitet_tip_kategori(tabela, id_sup, emertimi);
                return result;
            }
        }

        ObjectResult<SelectAllActiveRecByEmertimi_Entitet_Result> IBaseRepository.SelectAllActiveRecByEmertimi_Entitet(string tabela, string emertimi)
        {
            using (var context = new tasketEntities1())
            {
                var result = context.SelectAllActiveRecByEmertimi_Entitet(tabela,emertimi);
                return result;
            }
        }

        ObjectResult<SelectAllActiveRecByEmertimi_Entitet_access_Result> IBaseRepository.SelectAllActiveRecByEmertimi_Entitet_access(string tabela, string emertimi)
        {
            using (var context = new tasketEntities1())
            {
                var result = context.SelectAllActiveRecByEmertimi_Entitet_access(tabela, emertimi);
                return result;
            }
        }

        ObjectResult<SelectAllActiveRecByEmertimi_Entitet_info_Result> IBaseRepository.SelectAllActiveRecByEmertimi_Entitet_info(string tabela, string emertimi)
        {
            using (var context = new tasketEntities1())
            {
                var result = context.SelectAllActiveRecByEmertimi_Entitet_info(tabela, emertimi);
                return result;
            }
        }

        ObjectResult<SelectAllActiveRecByEmertimi_Entitet_kategori_Result> IBaseRepository.SelectAllActiveRecByEmertimi_Entitet_kategori(string tabela, string emertimi)
        {
            using (var context = new tasketEntities1())
            {
                var result = context.SelectAllActiveRecByEmertimi_Entitet_kategori(tabela, emertimi);
                return result;
            }
        }

        ObjectResult<SelectAllActiveRecByEmertimi_Entitet_tip_Result> IBaseRepository.SelectAllActiveRecByEmertimi_Entitet_tip(string tabela, string emertimi)
        {
            using (var context = new tasketEntities1())
            {
                var result = context.SelectAllActiveRecByEmertimi_Entitet_tip(tabela, emertimi);
                return result;
            }
        }

        ObjectResult<SelectAllActiveRecByEmertimi_Entitet_tip_info_Result> IBaseRepository.SelectAllActiveRecByEmertimi_Entitet_tip_info(string tabela, string emertimi)
        {
            using (var context = new tasketEntities1())
            {
                var result = context.SelectAllActiveRecByEmertimi_Entitet_tip_info(tabela, emertimi);
                return result;
            }
        }

        ObjectResult<SelectAllActiveRecByEmertimi_Entitet_tip_info_ch_Result> IBaseRepository.SelectAllActiveRecByEmertimi_Entitet_tip_info_ch(string tabela, string emertimi)
        {
            using (var context = new tasketEntities1())
            {
                var result = context.SelectAllActiveRecByEmertimi_Entitet_tip_info_ch(tabela, emertimi);
                return result;
            }
        }

        ObjectResult<SelectAllActiveRecByEmertimi_nder_Entitet_kategori_Result> IBaseRepository.SelectAllActiveRecByEmertimi_nder_Entitet_kategori(string tabela, string emertimi)
        {
            using (var context = new tasketEntities1())
            {
                var result = context.SelectAllActiveRecByEmertimi_nder_Entitet_kategori(tabela, emertimi);
                return result;
            }
        }

        ObjectResult<SelectAllActiveRecByEmertimi_nder_Entitet_tip_kategori_Result> IBaseRepository.SelectAllActiveRecByEmertimi_nder_Entitet_tip_kategori(string tabela, string emertimi)
        {
            using (var context = new tasketEntities1())
            {
                var result = context.SelectAllActiveRecByEmertimi_nder_Entitet_tip_kategori(tabela, emertimi);
                return result;
            }
        }

       

       
        ObjectResult<SelectAllActiveRecByKodiAndSup_Entitet_Result> IBaseRepository.SelectAllActiveRecByKodiAndSup_Entitet(string tabela, string kodi, string id_sup)
        {
            using (var context = new tasketEntities1())
            {
                var result = context.SelectAllActiveRecByKodiAndSup_Entitet(tabela,kodi,id_sup);
                return result;
            }
        }

        ObjectResult<SelectAllActiveRecByKodi_Entitet_Result> IBaseRepository.SelectAllActiveRecByKodi_Entitet(string tabela, string kodi)
        {
            using (var context = new tasketEntities1())
            {
                var result = context.SelectAllActiveRecByKodi_Entitet(tabela,kodi);
                return result;
            }
        }


       

        ObjectResult<SelectAllActiveRecBySup_Entitet_Result> IBaseRepository.SelectAllActiveRecBySup_Entitet(string tabela, string id_sup)
        {
            using (var context = new tasketEntities1())
            {
                var result = context.SelectAllActiveRecBySup_Entitet(tabela,id_sup);
                return result;
            }
        }

        ObjectResult<SelectAllActiveRecBySup_Entitet_access_Result> IBaseRepository.SelectAllActiveRecBySup_Entitet_access(string tabela, string id_sup)
        {
            using (var context = new tasketEntities1())
            {
                var result = context.SelectAllActiveRecBySup_Entitet_access(tabela, id_sup);
                return result;
            }
        }

        ObjectResult<SelectAllActiveRecBySup_Entitet_info_Result> IBaseRepository.SelectAllActiveRecBySup_Entitet_info(string tabela, string id_sup)
        {
            using (var context = new tasketEntities1())
            {
                var result = context.SelectAllActiveRecBySup_Entitet_info(tabela, id_sup);
                return result;
            }
        }

        ObjectResult<SelectAllActiveRecBySup_Entitet_kategori_Result> IBaseRepository.SelectAllActiveRecBySup_Entitet_kategori(string tabela, string id_sup)
        {
            using (var context = new tasketEntities1())
            {
                var result = context.SelectAllActiveRecBySup_Entitet_kategori(tabela, id_sup);
                return result;
            }
        }

        ObjectResult<SelectAllActiveRecBySup_Entitet_tip_Result> IBaseRepository.SelectAllActiveRecBySup_Entitet_tip(string tabela, string id_sup)
        {
            using (var context = new tasketEntities1())
            {
                var result = context.SelectAllActiveRecBySup_Entitet_tip(tabela, id_sup);
                return result;
            }
        }

        ObjectResult<SelectAllActiveRecBySup_Entitet_tip_info_Result> IBaseRepository.SelectAllActiveRecBySup_Entitet_tip_info(string tabela, string id_sup)
        {
            using (var context = new tasketEntities1())
            {
                var result = context.SelectAllActiveRecBySup_Entitet_tip_info(tabela, id_sup);
                return result;
            }
        }

        ObjectResult<SelectAllActiveRecBySup_Entitet_tip_info_ch_Result> IBaseRepository.SelectAllActiveRecBySup_Entitet_tip_info_ch(string tabela, string id_sup)
        {
            using (var context = new tasketEntities1())
            {
                var result = context.SelectAllActiveRecBySup_Entitet_tip_info_ch(tabela, id_sup);
                return result;
            }
        }

        ObjectResult<SelectAllActiveRecBySup_nder_Entitet_kategori_Result> IBaseRepository.SelectAllActiveRecBySup_nder_Entitet_kategori(string tabela, string id_sup)
        {
            using (var context = new tasketEntities1())
            {
                var result = context.SelectAllActiveRecBySup_nder_Entitet_kategori(tabela, id_sup);
                return result;
            }
        }

        ObjectResult<SelectAllActiveRecBySup_nder_Entitet_tip_kategori_Result> IBaseRepository.SelectAllActiveRecBySup_nder_Entitet_tip_kategori(string tabela, string id_sup)
        {
            using (var context = new tasketEntities1())
            {
                var result = context.SelectAllActiveRecBySup_nder_Entitet_tip_kategori(tabela, id_sup);
                return result;
            }
        }

       

       

        ObjectResult<SelectAllActiveRecByTipId_Entitet_Result> IBaseRepository.SelectAllActiveRecByTipId_Entitet(string tabela, string tip_id)
        {
            using (var context = new tasketEntities1())
            {
                var result = context.SelectAllActiveRecByTipId_Entitet(tabela,tip_id);
                return result;
            }
        }



        ObjectResult<SelectAllActiveRecByTipInfoId_Entitet_tip_info_ch_Result> IBaseRepository.SelectAllActiveRecByTipInfoId_Entitet_tip_info_ch(string tabela, string tip_info_id)
        {
            using (var context = new tasketEntities1())
            {
                var result = context.SelectAllActiveRecByTipInfoId_Entitet_tip_info_ch(tabela,tip_info_id);
                return result;
            }
        }

        ObjectResult<SelectAllActiveRec_Entitet_Result> IBaseRepository.SelectAllActiveRec_Entitet(string tabela)
        {
            using (var context = new tasketEntities1())
            {
                var result = context.SelectAllActiveRec_Entitet(tabela);
                return result;
            }
        }

        ObjectResult<SelectAllActiveRec_Entitet_access_Result> IBaseRepository.SelectAllActiveRec_Entitet_access(string tabela)
        {
            using (var context = new tasketEntities1())
            {
                var result = context.SelectAllActiveRec_Entitet_access(tabela);
                return result;
            }
        }

        ObjectResult<SelectAllActiveRec_Entitet_info_Result> IBaseRepository.SelectAllActiveRec_Entitet_info(string tabela)
        {
            using (var context = new tasketEntities1())
            {
                var result = context.SelectAllActiveRec_Entitet_info(tabela);
                return result;
            }
        }

        ObjectResult<SelectAllActiveRec_Entitet_kategori_Result> IBaseRepository.SelectAllActiveRec_Entitet_kategori(string tabela)
        {
            using (var context = new tasketEntities1())
            {
                var result = context.SelectAllActiveRec_Entitet_kategori(tabela);
                return result;
            }
        }

        ObjectResult<SelectAllActiveRec_Entitet_tip_Result> IBaseRepository.SelectAllActiveRec_Entitet_tip(string tabela)
        {
            using (var context = new tasketEntities1())
            {
                var result = context.SelectAllActiveRec_Entitet_tip(tabela);
                return result;
            }
        }

        ObjectResult<SelectAllActiveRec_Entitet_tip_info_Result> IBaseRepository.SelectAllActiveRec_Entitet_tip_info(string tabela)
        {
            using (var context = new tasketEntities1())
            {
                var result = context.SelectAllActiveRec_Entitet_tip_info(tabela);
                return result;
            }
        }

        ObjectResult<SelectAllActiveRec_Entitet_tip_info_ch_Result> IBaseRepository.SelectAllActiveRec_Entitet_tip_info_ch(string tabela)
        {
            using (var context = new tasketEntities1())
            {
                var result = context.SelectAllActiveRec_Entitet_tip_info_ch(tabela);
                return result;
            }
            throw new NotImplementedException();
        }

        ObjectResult<SelectAllActiveRec_nder_Entitet_kategori_Result> IBaseRepository.SelectAllActiveRec_nder_Entitet_kategori(string tabela)
        {
            using (var context = new tasketEntities1())
            {
                var result = context.SelectAllActiveRec_nder_Entitet_kategori(tabela);
                return result;
            }
        }

        ObjectResult<SelectAllActiveRec_nder_Entitet_tip_kategori_Result> IBaseRepository.SelectAllActiveRec_nder_Entitet_tip_kategori(string tabela)
        {
            using (var context = new tasketEntities1())
            {
                var result = context.SelectAllActiveRec_nder_Entitet_tip_kategori(tabela);
                return result;
            }
        }
    }
}