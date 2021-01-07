using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cds.APITemplate.Api.ItemFeature
{
    /// <summary>
    /// LogisticProductViewModel
    /// </summary>
    public sealed class LogisticProductViewModel
    {
        /// <summary>
        /// product id
        /// </summary>
        public string ProductId { get; set; }

        /// <summary>
        /// shipped quantity
        /// </summary>
        public int ShippedQuantity { get; set; }

    }
}
