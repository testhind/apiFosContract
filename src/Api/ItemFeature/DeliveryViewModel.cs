using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cds.APITemplate.Api.ItemFeature
{
    /// <summary>
    /// DeliveryModel
    /// </summary>
    public sealed class DeliveryViewModel
    {
        /// <summary>
        /// The first name.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// The last name.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Tthe address line1.
        /// </summary>
        public string AddressLine1 { get; set; }

        /// <summary>
        /// The address line2.
        /// </summary>
        public string AddressLine2 { get; set; }

        /// <summary>
        /// The address line3.
        /// </summary>
        public string AddressLine3 { get; set; }

        /// <summary>
        /// The company.
        /// </summary>
        public string Company { get; set; }

        /// <summary>
        /// The city.
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// The state or region.
        /// </summary>
        public string StateOrRegion { get; set; }

        /// <summary>
        ///The postal code.
        /// </summary>
        [Required]
        public string PostalCode { get; set; }

        /// <summary>
        /// The country code.
        /// </summary>
        public string CountryCode { get; set; }

        /// <summary>
        /// The phone.
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// The email.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// The promise date min.
        /// </summary>
        public DateTimeOffset PromiseDateMin { get; set; }

        /// <summary>
        /// The promise date max.
        /// </summary>
        public DateTimeOffset PromiseDateMax { get; set; }

        /// <summary>
        /// delivery date min
        /// </summary>
        public DateTimeOffset DeliveryDateMin { get; set; }

        /// <summary>
        /// delivery date max
        /// </summary>
        public DateTimeOffset DeliveryDateMax { get; set; }
       
    }
}
