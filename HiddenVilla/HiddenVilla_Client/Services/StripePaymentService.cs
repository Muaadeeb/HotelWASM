using HiddenVilla_Client.Services.Interfaces;
using Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace HiddenVilla_Client.Services
{
    public class StripePaymentService : IStripePaymentService
    {
        private readonly HttpClient _client;

        public StripePaymentService(HttpClient client)
        {
            _client = client;
        }

        public async Task<SuccessModel> CheckOut(StripePaymentDTO stripePaymentDto)
        {
            //var content = JsonConvert.SerializeObject(stripePaymentDto);
            JsonContent content = JsonContent.Create(stripePaymentDto);
            var response = await _client.PostAsync("api/stripepayment/create", content);

            if (response.IsSuccessStatusCode)
            {
                var contentTemp = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<SuccessModel>(contentTemp);
            }
            else
            {
                var contentTemp = await response.Content.ReadAsStringAsync();
                var errorModel = JsonConvert.DeserializeObject<ErrorModel>(contentTemp);
                throw new Exception(errorModel.ErrorMessage);
            }




        }
    }
}
