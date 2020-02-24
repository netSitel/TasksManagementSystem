using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TasksManagementSystem.Models;

namespace TasksManagementSystem.Service
{
    public class AdminService
    {
        public List<SelectListItem> GetEntitetet()
        {
            using (var context = new tasketDb())
            {
                List<SelectListItem> Entietet = new List<SelectListItem>();
                Entietet = context.entitetet.Select(n => new SelectListItem
                {
                    Value = n.nrrendor.ToString(),
                    Text = n.entitet
                }).ToList();
                var entitetTip = new SelectListItem()
                {
                    Value = null,
                    Text = "--Zgjidh--"
                };
                Entietet.Insert(0, entitetTip);
                return Entietet;
            }
        }

        public List<konfigurime> GetKonfigurime()
        {
            using (var context = new tasketDb())
            {
                return context.konfigurime.ToList();

            }
        }
    }
}