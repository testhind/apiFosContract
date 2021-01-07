using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cds.APITemplate.Api.ItemFeature
{
    /// <summary>
    /// PropertyModel
    /// </summary>
    public sealed class CarrierViewModel
    {
        /// <summary>
        /// Carrier code.
        /// </summary>
        [Required]
        public string CarrierCode { get; set; }

        /// <summary>
        /// Delivery mode.
        /// </summary>
        [Required]
        public string DeliveryMode { get; set; }
    }
}
