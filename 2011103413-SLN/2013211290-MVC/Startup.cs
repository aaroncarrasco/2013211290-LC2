﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_2013211290_MVC.Startup))]
namespace _2013211290_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
