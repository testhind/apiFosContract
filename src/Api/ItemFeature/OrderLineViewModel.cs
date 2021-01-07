using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cds.APITemplate.Api.ItemFeature
{
    /// <summary>
    /// ItemModel
    /// </summary>
    public sealed class OrderLineViewModel
    {
        /// <summary>
        /// Line id
        /// </summary>
        public int LineId { get; set; }

        /// <summary>
        ///Status.
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// The product.
        /// </summary>
        public ProductViewModel Product { get; set; }

        /// <summary>
        /// The Delivery.
        /// </summary>
        public DeliveryViewModel Delivery { get; set; }

        /// <summary>
        /// The Shipping.
        /// </summary>
        public ShippingViewModel Shipping { get; set; }


        /// <summary>
        /// The Carrier.
        /// </summary>
        public CarrierViewModel Carrier { get; set; }

        /// <summary>
        /// Gets or sets the properties.
        /// </summary>
        [Required]
        public IReadOnlyCollection<PropertyViewModel> Properties { get; set; }
    }
}
