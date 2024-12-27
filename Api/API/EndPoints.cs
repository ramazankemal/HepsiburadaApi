using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.API
{
    public static class EndPoints
    {
        //diğer endPoint' lere şu adresten ulaşabilirsiniz : https://developers.hepsiburada.com/


        public static string PostStockUpdateListing =string.Format("https://listing-external.hepsiburada.com/listings/merchantid/{0}/stock-uploads",ApiConnectInfo.MerchantID);
        public static string PostPriceUpdateListing =string.Format("https://listing-external.hepsiburada.com/listings/merchantid/{0}/price-uploads",ApiConnectInfo.MerchantID);
        public static string GetAllOrder = string.Format("https://oms-external.hepsiburada.com/orders/merchantid/{0}?offset=0&limit=100",ApiConnectInfo.MerchantID);
        public static string GetOrder =string.Format("https://oms-external.hepsiburada.com/orders/merchantid/{0}/ordernumber/",ApiConnectInfo.MerchantID);
        public static string GetPackageInformation =string.Format("https://oms-external.hepsiburada.com/packages/merchantid/{0}",ApiConnectInfo.MerchantID);
        public static string GetOrderDetails = string.Format("https://oms-external.hepsiburada.com/orders/merchantid/{0}/ordernumber/",ApiConnectInfo.MerchantID);
        public static string UpdatePackage =string.Format("https://oms-external.hepsiburada.com/packages/merchantid/{0}",ApiConnectInfo.MerchantID);
        public static string SendInvoiceLink = string.Format("https://oms-external.hepsiburada.com/packages/merchantid/{0}",ApiConnectInfo.MerchantID);
        public static string SendTrackingNumber = "https://radium.hepsiburada.com/api/order/update_tracking_number";
        public static string PostPackageSplit = string.Format("https://oms-external.hepsiburada.com/packages/merchantid/{0}/packagenumber/{packagenumber}/split",ApiConnectInfo.MerchantID);
    }
}
