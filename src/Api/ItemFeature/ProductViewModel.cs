using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cds.APITemplate.Api.ItemFeature
{
    /// <summary>
    /// ProductModel
    /// </summary>
    public sealed class ProductViewModel
    {
        /// <summary>
        /// The product id.
        /// </summary>
        public string ProductId { get; set; }

        /// <summary>
        /// Gets or sets the Quantity.
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Shipped quantity.
        /// </summary>
        public int ShippedQuantity { get; set; }
    }
}
