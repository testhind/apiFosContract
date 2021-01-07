using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Cds.APITemplate.Api.ItemFeature
{
    /// <summary>
    /// Create cycle couting command view model
    /// </summary>
    public sealed class OrderModel
    {

        /// <summary>
        /// Gets or sets the external order id.
        /// </summary>
        [Required]
       public string ExternalOrderId { get; set; }

        /// <summary>
        /// Gets or sets the partner order id.
        /// </summary>
        [Required]
        public string PartnerOrderId { get; set; }

        /// <summary>
        /// Gets or sets the stock owner id.
        /// </summary>
        [Required]
        public int StockOwnerID { get; set; }
        

        /// <summary>
        /// Gets or sets the lines.
        /// </summary>
        [Required]
        public IReadOnlyCollection<LineModel> Lines { get; set; }


        /// <summary>
        /// Gets or sets the properties.
        /// </summary>
        [Required]
        public IReadOnlyCollection<PropertyModel> Properties { get; set; }

    }
}