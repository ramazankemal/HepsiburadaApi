using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.API
{
    public static class ApiConnectInfo
    {
        public static string MerchantID = "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx"; //hepsiburada satıcı panelinden girerek bu bilgiye ulaşabilirsiniz
        public static string Key = "xxxxx"; //hepsiburada satıcı panelinden girerek bu bilgiye ulaşabilirsiniz
        public static string ApiAccount = "xxxxx_dev"; //hepsiburada satıcı panelinden girerek api bilgileri kısmında oluşturdugunuz hesaptır
        public static string GetAuthInfo() //base64 formatında auth bilginizei döner
        {
            return Convert.ToBase64String(Encoding.ASCII.GetBytes($"{MerchantID}:{Key}"));
        }
    }
}
