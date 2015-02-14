// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GuidItem.cs" company="Devville">
//   Copyright © 2015 All Right Reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Devville.Websites.Guids.Web.Models
{
    using System;

    /// <summary>
    ///     Represents Guid Item data type.
    /// </summary>
    /// <author>Ahmed Magdy (ahmed.magdy@devville.net)</author>
    /// <created>2/14/2015</created>
    public class GuidItem
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the braces lower case format.
        /// </summary>
        /// <value>
        ///     The braces lower case format.
        /// </value>
        /// <author>Ahmed Magdy (ahmed.magdy@devville.net)</author>
        /// <created>2/14/2015</created>
        public string BracesLowerCaseFormat { get; set; }

        /// <summary>
        ///     Gets or sets the braces upper case format.
        /// </summary>
        /// <value>
        ///     The braces upper case format.
        /// </value>
        /// <author>Ahmed Magdy (ahmed.magdy@devville.net)</author>
        /// <created>2/14/2015</created>
        public string BracesUpperCaseFormat { get; set; }

        /// <summary>
        ///     Gets or sets the digital lower case format.
        /// </summary>
        /// <value>
        ///     The digital lower case format.
        /// </value>
        /// <author>
        ///     Ahmed Magdy (ahmed.magdy@devville.net)
        /// </author>
        /// <created>2/14/2015</created>
        public string DigitalLowerCaseFormat { get; set; }

        /// <summary>
        ///     Gets or sets the digital upper case format.
        /// </summary>
        /// <value>
        ///     The digital upper case format.
        /// </value>
        /// <author>Ahmed Magdy (ahmed.magdy@devville.net)</author>
        /// <created>2/14/2015</created>
        public string DigitalUpperCaseFormat { get; set; }

        /// <summary>
        ///     Gets or sets the hexadecimal lower case format.
        /// </summary>
        /// <value>
        ///     The hexadecimal lower case format.
        /// </value>
        /// <author>Ahmed Magdy (ahmed.magdy@devville.net)</author>
        /// <created>2/14/2015</created>
        public string HexadecimalLowerCaseFormat { get; set; }

        /// <summary>
        ///     Gets or sets the hexadecimal upper case format.
        /// </summary>
        /// <value>
        ///     The hexadecimal upper case format.
        /// </value>
        /// <author>Ahmed Magdy (ahmed.magdy@devville.net)</author>
        /// <created>2/14/2015</created>
        public string HexadecimalUpperCaseFormat { get; set; }

        /// <summary>
        ///     Gets or sets the hyphens lower case format.
        /// </summary>
        /// <value>
        ///     The hyphen lower case format.
        /// </value>
        /// <author>Ahmed Magdy (ahmed.magdy@devville.net)</author>
        /// <created>2/14/2015</created>
        public string HyphensLowerCaseFormat { get; set; }

        /// <summary>
        ///     Gets or sets the hyphens upper case format.
        /// </summary>
        /// <value>
        ///     The hyphen upper case format.
        /// </value>
        /// <author>Ahmed Magdy (ahmed.magdy@devville.net)</author>
        /// <created>2/14/2015</created>
        public string HyphensUpperCaseFormat { get; set; }

        /// <summary>
        ///     Gets or sets the parentheses lower case format.
        /// </summary>
        /// <value>
        ///     The parentheses lower case format.
        /// </value>
        /// <author>Ahmed Magdy (ahmed.magdy@devville.net)</author>
        /// <created>2/14/2015</created>
        public string ParenthesesLowerCaseFormat { get; set; }

        /// <summary>
        ///     Gets or sets the parentheses upper case format.
        /// </summary>
        /// <value>
        ///     The parentheses upper case format.
        /// </value>
        /// <author>Ahmed Magdy (ahmed.magdy@devville.net)</author>
        /// <created>2/14/2015</created>
        public string ParenthesesUpperCaseFormat { get; set; }

        /// <summary>
        ///     Gets or sets the raw.
        /// </summary>
        /// <value>
        ///     The raw.
        /// </value>
        /// <author>Ahmed Magdy (ahmed.magdy@devville.net)</author>
        /// <created>2/14/2015</created>
        public Guid Raw { get; set; }

        #endregion
    }
}