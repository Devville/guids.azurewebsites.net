// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NewController.cs" company="Devville">
//   Copyright © 2015 All Right Reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Devville.Websites.Guids.Web.Controllers
{
    using System;
    using System.Web.Http;
    using System.Web.Http.Cors;

    using Devville.Websites.Guids.Web.Models;

    using NLog;

    /// <summary>
    ///     New Guid Web API controller
    /// </summary>
    /// <author>Ahmed Magdy (ahmed.magdy@devville.net)</author>
    /// <created>2/14/2015</created>
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class NewController : ApiController
    {
        #region Public Methods and Operators

        /// <summary>
        ///     Gets the unique identifier.
        /// </summary>
        /// <returns>The Guid Item</returns>
        /// <author>Ahmed Magdy (ahmed.magdy@devville.net)</author>
        /// <created>2/14/2015</created>
        public GuidItem GetGuid()
        {
            var logger = LogManager.GetCurrentClassLogger();
            Guid guid = Guid.NewGuid();
            logger.Trace("Guid: {0} generated.", guid);
            var result = new GuidItem
                             {
                                 Raw = guid,
                                 BracesLowerCaseFormat = guid.ToString("B"),
                                 BracesUpperCaseFormat = guid.ToString("B").ToUpperInvariant(),
                                 DigitalLowerCaseFormat = guid.ToString("N"),
                                 DigitalUpperCaseFormat = guid.ToString("N").ToUpperInvariant(),
                                 HyphensLowerCaseFormat = guid.ToString("D"),
                                 HyphensUpperCaseFormat = guid.ToString("D").ToUpperInvariant(),
                                 ParenthesesLowerCaseFormat = guid.ToString("P"),
                                 ParenthesesUpperCaseFormat = guid.ToString("P").ToUpperInvariant(),
                                 HexadecimalLowerCaseFormat = guid.ToString("X"),
                                 HexadecimalUpperCaseFormat = guid.ToString("X").ToUpperInvariant()
                             };

            return result;
        }

        #endregion
    }
}