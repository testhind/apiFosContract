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
    public sealed class ProductModel
    {
        /// <summary>
        /// Gets or sets the product id.
        /// </summary>
        [Required]
        public string ProductId { get; set; }

        /// <summary>
        /// Gets or sets the Quantity.
        /// </summary>
        [Required]
        public int Quantity { get; set; }
    }
}
