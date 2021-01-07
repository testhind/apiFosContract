using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cds.APITemplate.Api.ItemFeature
{
    /// <summary>
    /// LineModel
    /// </summary>
    public sealed class LineModel
    {
        /// <summary>
        /// Gets or sets line id. 
        /// </summary>
        [Required]
        public int LineId { get; set; }

        /// <summary>
        /// Gets or sets the product.
        /// </summary>
        [Required]
        public ProductModel Product { get; set; }

        /// <summary>
        /// Gets or sets the Delivery.
        /// </summary>
        [Required]
        public DeliveryModel Delivery { get; set; }

        /// <summary>
        /// Gets or sets the properties.
        /// </summary>
        [Required]
        public IReadOnlyCollection<PropertyModel> Properties { get; set; }
    }
}
