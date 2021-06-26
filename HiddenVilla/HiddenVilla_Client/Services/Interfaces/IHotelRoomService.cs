using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HiddenVilla_Client.Services.Interfaces
{
    public interface IHotelRoomService
    {
        public Task<IEnumerable<HotelRoomDTO>> GetHotelRoomsAsync(string checkInDate, string checkOutDate);
        public Task<HotelRoomDTO> GetHotelRoomDetailsAsync(int roomId, string checkInDate, string checkOutDate);
    }
}
