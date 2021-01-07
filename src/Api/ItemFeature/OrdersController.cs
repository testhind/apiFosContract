using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Cds.APITemplate.Domain.ItemAggregate;
using Cds.APITemplate.Domain.ItemAggregate.Abstractions;
using Cds.APITemplate.Infrastructure.ItemRepository.Abstractions;
using Cds.Foundation.Web.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cds.APITemplate.Api.ItemFeature
{
    /// <summary>
    /// Represents the controller to handle <see cref="Item"/>s.
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class OrdersController : ControllerBase
    {
        #region Fields

        private readonly IItemReadRepository _read;
        private readonly ItemHandler _handler;

        #endregion

        /// <summary>
        /// Initializes a new instance of the <see cref="OrdersController"/> class.
        /// </summary>
        /// <param name="read">The read repository.</param>
        /// <param name="handler">The repository.</param>
        public OrdersController(IItemReadRepository read, ItemHandler handler)
        {
            _read = read ?? throw new ArgumentNullException(nameof(read));
            _handler = handler ?? throw new ArgumentNullException(nameof(handler));
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="order"></param>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> PostCommand([FromBody] OrderModel order)
        {
            await Task.Yield();
            return CreatedAtAction(nameof(OrdersController.Get), new { id = 1 }, 1);
        }


        //le retour 201 

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet()]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<OrderViewModel>> GetOrderStatus([FromQuery(Name = "partnerorderid")] string orderSellerId)
        {
            var orderLine = new OrderLineViewModel()
            {
                Delivery = new DeliveryViewModel { }
                    ,
                Product = new ProductViewModel()
            };
            var orderLineList = new List<OrderLineViewModel>();
            orderLineList.Add(orderLine);

           var orderStatus = new OrderViewModel
            {
                Lines = orderLineList
           };


            await Task.Yield();
            return orderStatus;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet("{orderId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<OrderViewModel>> Get([FromRoute] string orderId)
        {
            var orderLine = new OrderLineViewModel()
            {
                Delivery = new DeliveryViewModel { }
                  ,
                Product = new ProductViewModel()
            };
            var orderLineList = new List<OrderLineViewModel>();
            orderLineList.Add(orderLine);

            var orderStatus = new OrderViewModel
            {
                Lines = orderLineList
            };

            await Task.Yield();
            return orderStatus;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="orderId"></param>
        /// <param name="logisticOrder"></param>
        /// <returns></returns>
        [HttpPatch("{orderId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> Patch([FromRoute] string orderId, [FromBody] LogisticOrderViewModel logisticOrder)
        {
            await Task.Yield();
            return CreatedAtAction(nameof(OrdersController.Get), new { id = 1 }, 1);
        }
       

    }
}
