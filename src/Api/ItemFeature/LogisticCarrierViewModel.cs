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
    public sealed class LogisticCarrierViewModel
    {
        /// <summary>
        /// carrier code
        /// </summary>
        public string CarrierCode { get; set; }

        /// <summary>
        /// delivery mode
        /// </summary>
        public string DeliveryMode { get; set; }

    }
}
