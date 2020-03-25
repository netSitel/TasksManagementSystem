using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TasksManagementSystem.Models
{
    public class VetiViewModel
    {
        public List<SelectListItem> SelectListEntity { get; set; }
        public int SelectedEntity { get; set; }

    }
}