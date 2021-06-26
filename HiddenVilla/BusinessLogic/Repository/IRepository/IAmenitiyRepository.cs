using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repository.IRepository
{
    public interface IAmenityRepository
    {
        public Task<HotelAmenityDTO> CreateHotelAmenityAsync(HotelAmenityDTO hotelAmenity);
        public Task<HotelAmenityDTO> UpdateHotelAmenityAsync(int amenityId, HotelAmenityDTO hotelAmenity);
        public Task<int> DeleteHotelAmenityAsync(int amenityId, string userId);
        public Task<IEnumerable<HotelAmenityDTO>> GetAllHotelAmenityAsync();
        public Task<HotelAmenityDTO> GetHotelAmenityAsync(int amenityId);
        public Task<HotelAmenityDTO> IsSameNameAmenityAlreadyExistsAsync(string name);
    }
}
