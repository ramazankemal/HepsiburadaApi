using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Request
{
    // hepsiburada stok adetini güncellemek için kullanılır
    public class UpdateStockAmountRequest
    {
       
        public string HepsiburadaSku { get; set; }
        public string MerchantSku { get; set; }
        public int AvailableStock { get; set; }
        public int MaximumPurchasableQuantity { get; set; }
    }
}
