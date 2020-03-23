using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TasksManagementSystem.Models
{
    public class PerdoruesViewModel
    {
        public AspNetUsers Users { get; set; }
        public List<AspNetUsers> UsersList { get; set; }
        public List<SelectListItem> UsersRoles { get; set; }
        public string SelectedRole { get; set; }
    }
}