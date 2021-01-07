using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Cds.APITemplate.Api.ItemFeature
{
    /// <summary>
    /// Order status view model
    /// </summary>
    public class LogisticOrderViewModel
    {       
        /// <summary>
        ///  Status.
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        ///  Status reason.
        /// </summary>
        public string StatusReason { get; set; }

        /// <summary>
        ///  Hexa stock owner id.
        /// </summary>
        public string HexaStockOwnerId { get; set; }

        /// <summary>
        /// Order total.
        /// </summary>
        public decimal OrderTotal { get; set; }

        /// <summary>
        /// logistic order lines 
        /// </summary>
        public IReadOnlyCollection<LogisticOrderLineViewModel> Lines { get; set; }

    }
}