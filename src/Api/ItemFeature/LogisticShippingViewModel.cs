using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cds.APITemplate.Api.ItemFeature
{
    /// <summary>
    /// DeliveryModel
    /// </summary>
    public sealed class LogisticShippingViewModel
    {
        /// <summary>
        /// shipping date min
        /// </summary>
        public DateTimeOffset ShippingDateMin { get; set; }

        /// <summary>
        /// shipping date max
        /// </summary>
        public DateTimeOffset ShippingDateMax { get; set; }

    }
}
