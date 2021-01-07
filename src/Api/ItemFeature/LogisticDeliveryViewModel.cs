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
    public sealed class LogisticDeliveryViewModel
    {
        /// <summary>
        /// delivery date min
        /// </summary>
        public DateTimeOffset DeliveryDateMin { get; set; }

        /// <summary>
        /// delivery date max
        /// </summary>
        public DateTimeOffset DeliveryDateMax { get; set; }

    }
}
