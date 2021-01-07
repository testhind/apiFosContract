using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cds.APITemplate.Api.ItemFeature
{
    /// <summary>
    /// LogisticOrderLineViewModel
    /// </summary>
    public sealed class LogisticOrderLineViewModel
    {
        /// <summary>
        /// Line id
        /// </summary>
        public int LineId { get; set; }

        /// <summary>
        ///  Status.
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// The Product.
        /// </summary>
        public LogisticProductViewModel Product { get; set; }

        /// <summary>
        /// The Delivery.
        /// </summary>
        public LogisticDeliveryViewModel Delivery { get; set; }

        /// <summary>
        /// The Shipping.
        /// </summary>
        public LogisticShippingViewModel Shipping { get; set; }

        /// <summary>
        /// The carrier.
        /// </summary>
        public LogisticCarrierViewModel Carrier { get; set; }

        
    }
}
