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

    }
}
