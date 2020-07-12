using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _91APPtest.Repository;
using _91APPtest.ViewModels.Order;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _91APPtest.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UpdataOrderController : ControllerBase
    {
        private readonly IUpdataOrderRepository<OrderListViewModels> _updata;
        public UpdataOrderController(IUpdataOrderRepository<OrderListViewModels> updata)
        {
            _updata = updata;
        }
        [HttpPost("api/OrderPost")]
        public void OrderGet(string[] objjson)
        {
            _updata.UpdataOrder(objjson);
            _updata.SaveShipping(objjson);
        }
    }
}
