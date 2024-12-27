using Api.Model.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Response
{
    //hepsiburada sipariş listesi için kullanılır
    public class OrderResponse
    {
        public int TotalCount { get; set; }
        public int Limit { get; set; }
        public int Offset { get; set; }
        public int PageCount { get; set; }
        public List<ItemModel> Items { get; set; }
    }
}
