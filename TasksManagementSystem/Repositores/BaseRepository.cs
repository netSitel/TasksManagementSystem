using System;
using System.Collections.Generic;
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

        int IBaseRepository.SelectAllActiveRec(string tabela)
        {
            using (var context = new tasketEntities1())
            {
                var result = context.SelectAllActiveRec(tabela);
                return result;
            }
        }

        int IBaseRepository.SelectAllActiveRecByEmertimi(string tabela, string emertimi)
        {
            using (var context = new tasketEntities1())
            {
                var result = context.SelectAllActiveRecByEmertimi(tabela,emertimi);
                return result;
            }
        }

        int IBaseRepository.SelectAllActiveRecByEmertimi2(string tabela, string emertimi)
        {
            using (var context = new tasketEntities1())
            {
                var result = context.SelectAllActiveRecByEmertimi2(tabela,emertimi);
                return result;
            }
        }

        int IBaseRepository.SelectAllActiveRecByEmertimiAndSup(string tabela, string id_sup, string emertimi)
        {
            using (var context = new tasketEntities1())
            {
                var result = context.SelectAllActiveRecByEmertimiAndSup(tabela,id_sup,emertimi);
                return result;
            }
        }

        int IBaseRepository.SelectAllActiveRecByKodi(string tabela, string kodi)
        {
            using (var context = new tasketEntities1())
            {
                var result = context.SelectAllActiveRecByKodi(tabela,kodi);
                return result;
            }
        }

        int IBaseRepository.SelectAllActiveRecByKodiAndSup(string tabela, string kodi, string id_sup)
        {
            using (var context = new tasketEntities1())
            {
                var result = context.SelectAllActiveRecByKodiAndSup(tabela,kodi,id_sup);
                return result;
            }
        }

        int IBaseRepository.SelectAllActiveRecByNrrendor(string tabela, string nrrendor)
        {
            using (var context = new tasketEntities1())
            {
                var result = context.SelectAllActiveRecByNrrendor(tabela,nrrendor);
                return result;
            }
        }

        int IBaseRepository.SelectAllActiveRecBySup(string tabela, string id_sup)
        {
            using (var context = new tasketEntities1())
            {
                var result = context.SelectAllActiveRecBySup(tabela,id_sup);
                return result;
            }
        }

        int IBaseRepository.SelectAllActiveRecByTipId(string tabela, string tip_id)
        {
            using (var context = new tasketEntities1())
            {
                var result = context.SelectAllActiveRecByTipId(tabela,tip_id);
                return result;
            }
        }

        int IBaseRepository.SelectAllActiveRecByTipId2(string tabela, string tip_id)
        {
            using (var context = new tasketEntities1())
            {
                var result = context.SelectAllActiveRecByTipId2(tabela,tip_id);
                return result;
            }
        }

        int IBaseRepository.SelectAllActiveRecByTipInfoId(string tabela, string tip_info_id)
        {
            using (var context = new tasketEntities1())
            {
                var result = context.SelectAllActiveRecByTipInfoId(tabela,tip_info_id);
                return result;
            }
        }
    }
}