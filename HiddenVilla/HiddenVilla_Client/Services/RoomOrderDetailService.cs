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
    public class RoomOrderDetailService : IRoomOrderDetailService
    {
        private readonly HttpClient _client;

        public RoomOrderDetailService(HttpClient client)
        {
            _client = client;
        }

        public async Task<RoomOrderDetailDTO> MarkPaymentSuccessful(RoomOrderDetailDTO details)
        {
            JsonContent content = JsonContent.Create(details);
            var response = await _client.PostAsync("api/roomorder/paymentsuccessful", content);

            if (response.IsSuccessStatusCode)
            {
                var contentTemp = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<RoomOrderDetailDTO>(contentTemp);
            }
            else
            {
                var contentTemp = await response.Content.ReadAsStringAsync();
                var errorModel = JsonConvert.DeserializeObject<ErrorModel>(contentTemp);
                throw new Exception(errorModel.ErrorMessage);
            }


        }

        public async Task<RoomOrderDetailDTO> SaveRoomOrderDetailAsync(RoomOrderDetailDTO details)
        {
            details.UserId = "dummy user";
            JsonContent content = JsonContent.Create(details);
            var response = await _client.PostAsync("api/roomorder/create", content);

            if (response.IsSuccessStatusCode)
            {
                var contentTemp = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<RoomOrderDetailDTO>(contentTemp);
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
