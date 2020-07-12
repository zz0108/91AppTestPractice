using _91APPtest.Repository;
using _91APPtest.ViewModels.Order;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _91APPtest.Service
{
    public class OrderService:IOrderRepository<OrderListViewModels>
    {
        private readonly IConfiguration _configuration;
        public OrderService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public OrderListViewModels GetOrderProducts()
        {
            var result = new OrderListViewModels();

            using (SqlConnection conn = new SqlConnection(_configuration.GetConnectionString("91AppTest")))
            {
                string sql = @"select * from Order_Table";
                var GetOrderProducts = conn.Query<OrderViewModels>(sql).ToList();
                result.Items = GetOrderProducts;
                return result;
            }
        }
    }
}
