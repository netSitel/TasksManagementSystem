using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;

namespace TasksManagementSystem.Repositores.Contracts
{
    public interface IBaseRepository
    {
        int SelectAllActiveRec(string tabela);
        int SelectAllActiveRecByEmertimi(string tabela, string emertimi);
        int SelectAllActiveRecByEmertimi2(string tabela, string emertimi);
        int SelectAllActiveRecByEmertimiAndSup(string tabela, string id_sup, string emertimi);
        int SelectAllActiveRecByKodi(string tabela, string kodi);
        int SelectAllActiveRecByKodiAndSup(string tabela, string kodi, string id_sup);
        int SelectAllActiveRecByNrrendor(string tabela, string nrrendor);
        int SelectAllActiveRecBySup(string tabela, string id_sup);
        int SelectAllActiveRecByTipId(string tabela, string tip_id);
        int SelectAllActiveRecByTipId2(string tabela, string tip_id);
        int SelectAllActiveRecByTipInfoId(string tabela, string tip_info_id);
        int FSHIJALL(string tabela);
    }
}
