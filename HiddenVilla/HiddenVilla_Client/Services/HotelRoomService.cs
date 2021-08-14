using HiddenVilla_Client.Services.Interfaces;
using Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace HiddenVilla_Client.Services
{
    public class HotelRoomService : IHotelRoomService
    {
        private readonly HttpClient _httpClient;

        public HotelRoomService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<HotelRoomDTO> GetHotelRoomDetailsAsync(int roomId, string checkInDate, string checkOutDate)
        {
            var response = await _httpClient.GetAsync($"api/hotelroom/{roomId}?checkInDate={checkInDate}&checkOutDate={checkOutDate}");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<HotelRoomDTO>(content);
            }
            else
            {
                var content = await response.Content.ReadAsStringAsync();
                var errorModel = JsonConvert.DeserializeObject<ErrorModel>(content);
                throw new Exception(errorModel.ErrorMessage);
            }
        }

        public async Task<IEnumerable<HotelRoomDTO>> GetHotelRoomsAsync(string checkInDate, string checkOutDate)
        {
            var response = await _httpClient.GetAsync($"api/hotelroom?checkInDate={checkInDate}&checkOutDate={checkOutDate}");
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<IEnumerable<HotelRoomDTO>>(content);
        }
    }
}
