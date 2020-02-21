using System;
using Microsoft.Owin;
using Owin;
using TasksManagementSystem.App_Start;

[assembly: OwinStartupAttribute(typeof(TasksManagementSystem.Startup))]
namespace TasksManagementSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            TasksManagementSystem.App_Start.Startup startup = new App_Start.Startup();
           startup.ConfigureAuth(app);
        }
       
    }
    
}