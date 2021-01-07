using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cds.APITemplate.Api.ItemFeature
{
    /// <summary>
    /// ShippingModel
    /// </summary>
    public sealed class ShippingViewModel
    {       
        /// <summary>
        /// Shipping date max
        /// </summary>
        public DateTimeOffset ShippingDateMax { get; set; }
    }
}
