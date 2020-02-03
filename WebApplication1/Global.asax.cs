using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace WebApplication1
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            //IConfigurationSource config = ConfigurationSourceFactory.Create();
            //ExceptionPolicyFactory factory = new ExceptionPolicyFactory(config);
            //ExceptionManager exManager = factory.CreateManager();
            //ExceptionPolicy.SetExceptionManager(factory.CreateManager());


            IConfigurationSource configurationSource = ConfigurationSourceFactory.Create();
            DatabaseFactory.SetDatabaseProviderFactory(new DatabaseProviderFactory());
            //ExceptionPolicy.SetExceptionManager(new ExceptionPolicyFactory(configurationSource).CreateManager());
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}