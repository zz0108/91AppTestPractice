using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _91APPtest.Repository;
using _91APPtest.ViewModels.Order;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace _91APPtest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly ILogger<OrderController> _logger;
        private readonly IOrderRepository<OrderListViewModels> _order;

        public OrderController(ILogger<OrderController> logger, IOrderRepository<OrderListViewModels> order)
        {
            _logger = logger;
            _order = order;
        }

        [HttpGet("api/OrderGet")]
        public List<OrderViewModels> OrderGet()
        {
            var obj = _order.GetOrderProducts().Items;
            return obj;
        }

    }
}
