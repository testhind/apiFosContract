using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Cds.APITemplate.Api.ItemFeature
{
    /// <summary>
    /// Order status view model
    /// </summary>
    public class OrderViewModel
    {
        /// <summary>
        ///  Order id
        /// </summary>
        public string OrderId { get; set; }

        /// <summary>
        /// External order id
        /// </summary>
        public string ExternalOrderId { get; set; }

        /// <summary>
        ///  partner order id.
        /// </summary>
        public string PartnerOrderId { get; set; }

        /// <summary>
        /// stock owner id
        /// </summary>
        public int StockOwnerId { get; set; }

        /// <summary>
        ///Status.
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        ///Technical status.
        /// </summary>
        public string TechnicalStatus { get; set; }

        /// <summary>
        /// Lines.
        /// </summary>
        public IReadOnlyCollection<OrderLineViewModel> Lines { get; set; }

        /// <summary>
        /// Gets or sets the properties.
        /// </summary>
        [Required]
        public IReadOnlyCollection<PropertyViewModel> Properties { get; set; }

    }
}