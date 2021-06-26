using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repository.IRepository
{
    public interface IHotelRoomRepository
    {
        public Task<HotelRoomDTO> CreateHotelRoomAsync(HotelRoomDTO hotelRoomDTO);
        public Task<IEnumerable<HotelRoomDTO>> GetAllHotelRoomsAsync(string checkInDate = null, string checkOutDate = null);
        public Task<HotelRoomDTO> UpdateHotelRoomAsync(HotelRoomDTO hotelRoomDTO, int roomId);
        public Task<HotelRoomDTO> GetHotelRoomAsync(int roomId, string checkInDate = null, string checkOutDate = null);
        public Task<int> DeleteHotelRoomAsync(int roomId);
        public Task<HotelRoomDTO> IsRoomUniqueAsync(string name, int roomId = 0);
    }
}
