using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repository.IRepository
{
    public interface IHotelImageRepository
    {
        public Task<int> CreateHotelRoomImageAsync(HotelRoomImageDTO image);
        public Task<int> DeleteHotelRoomImageByImageIdAsync(int imageId);
        public Task<int> DeleteHotelRoomImageByRoomIdAsync(int roomId);
        public Task<int> DeleteHotelRoomImageByImageUrlAsync(string imageUrl);
        public Task<IEnumerable<HotelRoomImageDTO>> GetHotelRoomImagesByRoomIdAsync(int roomId);
    }
}
