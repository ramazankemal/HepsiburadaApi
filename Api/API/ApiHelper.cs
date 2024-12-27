using Api.Request;
using Api.Response;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Api.API
{
    public class ApiHelper : IApiHelper
    {
        private HttpClient _httpClient;
        public ApiHelper(HttpClient client)
        {
            _httpClient= client;
        }
        /// <summary>
        /// Tüm siparişleri getirir
        /// </summary>
        /// <returns></returns>
        public async Task<OrderResponse> GetOrders()
        {
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            if (!_httpClient.DefaultRequestHeaders.UserAgent.Any(ua => ua.ToString() == ApiConnectInfo.ApiAccount))
            {
                _httpClient.DefaultRequestHeaders.UserAgent.ParseAdd(ApiConnectInfo.ApiAccount);
            }
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", ApiConnectInfo.GetAuthInfo());

            string url = EndPoints.GetAllOrder;

            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync(url);
                string strResponse = await response.Content.ReadAsStringAsync();
                response.EnsureSuccessStatusCode();

                var orderResponse = JsonConvert.DeserializeObject<OrderResponse>(strResponse);


                return orderResponse;
            }
            catch (HttpRequestException ex)
            {            
                //hata fırlat
                return new OrderResponse();
            }
        }
        /// <summary>
        /// siparişe ait paketin durumunu günceller
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<bool> UpdatePackage(UpdatePackageRequest request)
        {
            string jsonString = JsonConvert.SerializeObject(request, Formatting.Indented);

            _httpClient.DefaultRequestHeaders.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            if (!_httpClient.DefaultRequestHeaders.UserAgent.Any(ua => ua.ToString() == ApiConnectInfo.ApiAccount))
            {
                _httpClient.DefaultRequestHeaders.UserAgent.ParseAdd(ApiConnectInfo.ApiAccount);
            }
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", ApiConnectInfo.GetAuthInfo());

            string url = EndPoints.UpdatePackage;

            try
            {
                var content = new StringContent(jsonString, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await _httpClient.PostAsync(url, content);
                string excep = await response.Content.ReadAsStringAsync();
                response.EnsureSuccessStatusCode();

                return true;
            }
            catch (Exception ex)
            {
                //hata fırlat
                return false;
            }
        }
        /// <summary>
        /// hepsiburada da mevcut stogun miktarını günceller
        /// </summary>
        /// <param name="requestList"></param>
        /// <returns></returns>
        public async Task<bool> UpdateStockAmount(List<UpdateStockAmountRequest> requestList)
        {
            string jsonString = JsonConvert.SerializeObject(requestList, Formatting.Indented);

            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            if (!_httpClient.DefaultRequestHeaders.UserAgent.Any(ua => ua.ToString() == ApiConnectInfo.ApiAccount))
            {
                _httpClient.DefaultRequestHeaders.UserAgent.ParseAdd(ApiConnectInfo.ApiAccount);
            }
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", ApiConnectInfo.GetAuthInfo());

            string url = EndPoints.PostStockUpdateListing;
            string excep = string.Empty;
            try
            {
                var content = new StringContent(jsonString, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await _httpClient.PostAsync(url, content);
                excep = await response.Content.ReadAsStringAsync();
                response.EnsureSuccessStatusCode();

                return true;

            }
            catch (Exception ex)
            {
                //Hata fırlat
                return false;
            }
        }
    }
}
