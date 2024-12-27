using Api.Model.Package;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Request
{
    // hepsiburada da siparişin paketini veya paketlerini durumunu güncellemek için kullanılır
    public class UpdatePackageRequest
    {       
            public PackageWarehouseModel Warehouse { get; set; }
            public string Barcode { get; set; }
            public string CargoCompany { get; set; }
            public string Carrier { get; set; }
            public string CreationReason { get; set; }
            public int Deci { get; set; }
            public List<PackageLineItemRequest> LineItemRequests { get; set; }
            public int ParcelQuantity { get; set; } 
    }
}
