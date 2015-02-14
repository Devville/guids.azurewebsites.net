// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BundleConfig.cs" company="Devville">
//   Copyright © 2015 All Right Reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Devville.Websites.Guids.Web.App_Start
{
    using System.Web.Optimization;

    /// <summary>
    ///     The bundle config.
    /// </summary>
    public class BundleConfig
    {
        #region Public Methods and Operators

        /// <summary>
        /// The register bundles.
        /// </summary>
        /// <param name="bundles">
        /// The bundles.
        /// </param>
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.UseCdn = true;
            BundleTable.EnableOptimizations = true; // force optimization while debugging

            const string JqueryCdn = "//ajax.aspnetcdn.com/ajax/jquery/jquery-2.1.3.min.js";
            Bundle jquery = new ScriptBundle("~/resources/jquery", JqueryCdn).Include("~/Scripts/jquery-{version}.js");
            Bundle app = new ScriptBundle("~/resources/scripts").Include("~/scripts/app.js");

            Bundle styles = new StyleBundle("~/resources/styles").Include("~/styles/normalize.css", "~/styles/site.css");

            bundles.Add(jquery);
            bundles.Add(app);
            bundles.Add(styles);
        }

        #endregion
    }
}