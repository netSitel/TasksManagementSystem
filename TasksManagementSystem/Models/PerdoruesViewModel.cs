using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TasksManagementSystem.Models
{
    public class PerdoruesViewModel
    {
        public AspNetUsers Users { get; set; }
        public List<AspNetUsers> UsersList { get; set; }
    }
}