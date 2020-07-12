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
    public class UpdataOrderServices : IUpdataOrderRepository<OrderListViewModels>
    {
        private readonly IConfiguration _configuration;
        public UpdataOrderServices(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public void UpdataOrder(string[] objjson)
        {
            foreach(var item in objjson)
            {
                using (SqlConnection conn = new SqlConnection(_configuration.GetConnectionString("91AppTest")))
                {
                    string sql = $@"update Order_Table
                                    set Status = N'To be shipped'
                                    where Order_Id = '{item}'";
                    conn.Query(sql);
                }
            }
        }
        public void SaveShipping(string[] objjson)
        {
            foreach (var item in objjson)
            {
                using(SqlConnection conn = new SqlConnection(_configuration.GetConnectionString("91AppTest")))
                {
                    string sql = $@"insert into Shipping_Order_Table
                                    values('S{DateTime.Now.ToString("yyyyMMddHHmmssfff")}','{item}','New',GETDATE())";
                    conn.Query(sql);
                }
            }
        }
    }
}
