using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksManagementSystem.Repositores.Contracts
{
   public interface INderBase
    {
        int spI_tbl_nder_analize_task(Nullable<int> analize_id, Nullable<int> task_id, Nullable<int> perdorues_id);
        int spI_tbl_nder_klient_project(Nullable<int> klient_id, Nullable<int> project_id, Nullable<int> perdorues_id);
        int spI_tbl_nder_nivel_teknologji(Nullable<int> nivel_id, Nullable<int> teknologji_id, Nullable<int> perdorues_id);
        int spI_tbl_nder_niveli_personel(Nullable<int> niveli_id, Nullable<int> personel_id, Nullable<int> perdorues_id);
        int spI_tbl_nder_niveli_skeda(Nullable<int> niveli_id, Nullable<int> skeda_id, Nullable<int> perdorues_id);
        int spI_tbl_nder_personel_analize(Nullable<int> personel_id, Nullable<int> analize_id, Nullable<int> perdorues_id);
        int spI_tbl_nder_personel_task(Nullable<int> personel_id, Nullable<int> task_id, Nullable<int> perdorues_id);
        int spI_tbl_nder_personel_teknologji(Nullable<int> personel_id, Nullable<int> teknologji_id, Nullable<int> perdorues_id);
        int spI_tbl_nder_personel_teknologji_nivel(Nullable<int> personel_id, Nullable<int> teknologji_id, Nullable<int> nivel_id, Nullable<int> perdorues_id);
        int spI_tbl_nder_project_analize(Nullable<int> project_id, Nullable<int> analize_id, Nullable<int> perdorues_id);
        int spI_tbl_nder_project_personel(Nullable<int> project_id, Nullable<int> personel_id, Nullable<int> perdorues_id);
        int spI_tbl_nder_project_task(Nullable<int> project_id, Nullable<int> task_id, Nullable<int> perdorues_id);
        int spI_tbl_nder_project_teknologji(Nullable<int> project_id, Nullable<int> teknologji_id, Nullable<int> perdorues_id);
        int spI_tbl_nder_pyetje_personel_nivel_testim_pyetjeinfo(Nullable<int> pyetje_id, Nullable<int> pyetje_info_id, Nullable<int> testim_id, Nullable<int> personel_id, Nullable<int> nivel_id, Nullable<int> perdorues_id);
        int spI_tbl_nder_skeda_personel(Nullable<int> skeda_id, Nullable<int> personel_id, Nullable<int> perdorues_id);
        int spI_tbl_nder_skeda_project(Nullable<int> skeda_id, Nullable<int> project_id, Nullable<int> perdorues_id);
    }
}
