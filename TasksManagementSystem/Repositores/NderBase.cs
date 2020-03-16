using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TasksManagementSystem.Models;
using TasksManagementSystem.Repositores.Contracts;

namespace TasksManagementSystem.Repositores
{
    public class NderBase : INderBase
    {
        int INderBase.spI_tbl_nder_analize_task(int? analize_id, int? task_id, int? perdorues_id)
        {
            using (var context = new taskDb())
            {
                var result = context.spI_tbl_nder_analize_task( analize_id,  task_id, perdorues_id);
                return result;
            }
        }

        int INderBase.spI_tbl_nder_klient_project(int? klient_id, int? project_id, int? perdorues_id)
        {
            using (var context = new taskDb())
            {
                var result = context.spI_tbl_nder_klient_project(klient_id, project_id, perdorues_id);
                return result;
            }
        }

        int INderBase.spI_tbl_nder_niveli_personel(int? niveli_id, int? personel_id, int? perdorues_id)
        {
            using (var context = new taskDb())
            {
                var result = context.spI_tbl_nder_niveli_personel(niveli_id, personel_id, perdorues_id);
                return result;
            }
        }

        int INderBase.spI_tbl_nder_niveli_skeda(int? niveli_id, int? skeda_id, int? perdorues_id)
        {
            using (var context = new taskDb())
            {
                var result = context.spI_tbl_nder_niveli_skeda(niveli_id, skeda_id, perdorues_id);
                return result;
            }
        }

        int INderBase.spI_tbl_nder_nivel_teknologji(int? nivel_id, int? teknologji_id, int? perdorues_id)
        {
            using (var context = new taskDb())
            {
                var result = context.spI_tbl_nder_nivel_teknologji(nivel_id, teknologji_id, perdorues_id);
                return result;
            }
        }

        int INderBase.spI_tbl_nder_personel_analize(int? personel_id, int? analize_id, int? perdorues_id)
        {
            using (var context = new taskDb())
            {
                var result = context.spI_tbl_nder_personel_analize(personel_id, analize_id, perdorues_id);
                return result;
            }
        }

        int INderBase.spI_tbl_nder_personel_task(int? personel_id, int? task_id, int? perdorues_id)
        {
            using (var context = new taskDb())
            {
                var result = context.spI_tbl_nder_personel_task(personel_id, task_id, perdorues_id);
                return result;
            }
        }

        int INderBase.spI_tbl_nder_personel_teknologji(int? personel_id, int? teknologji_id, int? perdorues_id)
        {
            using (var context = new taskDb())
            {
                var result = context.spI_tbl_nder_personel_teknologji(personel_id, teknologji_id, perdorues_id);
                return result;
            }
        }

        int INderBase.spI_tbl_nder_personel_teknologji_nivel(int? personel_id, int? teknologji_id, int? nivel_id, int? perdorues_id)
        {
            using (var context = new taskDb())
            {
                var result = context.spI_tbl_nder_personel_teknologji_nivel(personel_id, teknologji_id,nivel_id, perdorues_id);
                return result;
            }
        }

        int INderBase.spI_tbl_nder_project_analize(int? project_id, int? analize_id, int? perdorues_id)
        {
            using (var context = new taskDb())
            {
                var result = context.spI_tbl_nder_project_analize(project_id, analize_id, perdorues_id);
                return result;
            }
        }

        int INderBase.spI_tbl_nder_project_personel(int? project_id, int? personel_id, int? perdorues_id)
        {
            using (var context = new taskDb())
            {
                var result = context.spI_tbl_nder_project_personel(project_id, personel_id, perdorues_id);
                return result;
            }
        }

        int INderBase.spI_tbl_nder_project_task(int? project_id, int? task_id, int? perdorues_id)
        {
            using (var context = new taskDb())
            {
                var result = context.spI_tbl_nder_project_task(project_id, task_id, perdorues_id);
                return result;
            }
        }

        int INderBase.spI_tbl_nder_project_teknologji(int? project_id, int? teknologji_id, int? perdorues_id)
        {
            using (var context = new taskDb())
            {
                var result = context.spI_tbl_nder_project_teknologji(project_id, teknologji_id, perdorues_id);
                return result;
            }
        }      

        int INderBase.spI_tbl_nder_pyetje_personel_nivel_testim_pyetjeinfo(int? pyetje_id, int? pyetje_info_id, int? testim_id, int? personel_id, int? nivel_id, int? perdorues_id)
        {
            using (var context = new taskDb())
            {
                var result = context.spI_tbl_nder_pyetje_personel_nivel_testim_pyetjeinfo(pyetje_id, pyetje_info_id, testim_id,  personel_id,  nivel_id,  perdorues_id);
                return result;
            }
        }

        int INderBase.spI_tbl_nder_skeda_personel(int? skeda_id, int? personel_id, int? perdorues_id)
        {
            using (var context = new taskDb())
            {
                var result = context.spI_tbl_nder_skeda_personel(skeda_id, personel_id, perdorues_id);
                return result;
            }
        }

        int INderBase.spI_tbl_nder_skeda_project(int? skeda_id, int? project_id, int? perdorues_id)
        {
            using (var context = new taskDb())
            {
                var result = context.spI_tbl_nder_skeda_project(skeda_id, project_id, perdorues_id);
                return result;
            }
        }
    }
}