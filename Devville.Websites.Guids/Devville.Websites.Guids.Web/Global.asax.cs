// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Global.asax.cs" company="Devville">
//   Copyright © 2015 All Right Reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Devville.Websites.Guids.Web
{
    using System;
    using System.Web;
    using System.Web.Http;
    using System.Web.Mvc;
    using System.Web.Optimization;
    using System.Web.Routing;

    using Devville.Websites.Guids.Web.App_Start;

    /// <summary>
    /// The global.
    /// </summary>
    public class Global : HttpApplication
    {
        #region Methods

        /// <summary>
        /// Handles the Start event of the Application control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        /// <author>Ahmed Magdy (ahmed.magdy@devville.net)</author>
        /// <created>2/14/2015</created>
        private void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        #endregion
    }
}