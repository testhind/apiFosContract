using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cds.APITemplate.Api.ItemFeature
{
    /// <summary>
    /// ShippingModel
    /// </summary>
    public sealed class ShippingModel
    {
        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        [Required]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        [Required]
        public string lastName { get; set; }

        /// <summary>
        /// Gets or sets the address line1.
        /// </summary>
        [Required]
        public string AddressLine1 { get; set; }

        /// <summary>
        /// Gets or sets the address line2.
        /// </summary>
        [Required]
        public string AddressLine2 { get; set; }

        /// <summary>
        /// Gets or sets the address line3.
        /// </summary>
        [Required]
        public string AddressLine3 { get; set; }

        /// <summary>
        /// Gets or sets the city.
        /// </summary>
        [Required]
        public string City { get; set; }

        /// <summary>
        /// Gets or sets the state or region.
        /// </summary>
        [Required]
        public string StateOrRegion { get; set; }

        /// <summary>
        /// Gets or sets the postal code.
        /// </summary>
        [Required]
        public string PostalCode { get; set; }

        /// <summary>
        /// Gets or sets the country code.
        /// </summary>
        [Required]
        public string CountryCode { get; set; }

        /// <summary>
        /// Gets or sets the mobile.
        /// </summary>
        [Required]
        public string Mobile { get; set; }

        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        [Required]
        public string Email { get; set; }
    }
}
