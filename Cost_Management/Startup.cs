﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Cost_Management.Startup))]
namespace Cost_Management
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
