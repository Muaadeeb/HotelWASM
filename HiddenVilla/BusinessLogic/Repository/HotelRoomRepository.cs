using Business.Repository.IRepository;
using DataAccess.Data;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repository
{
    public class HotelRoomRepository : IHotelRoomRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public HotelRoomRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public Task<HotelRoomDTO> CreateHotelRoom(HotelRoomDTO hotelRoomDTO)
        {
            var addedHotelRoom = _applicationDbContext.HotelRooms.Add();
        }

        public Task<IEnumerable<HotelRoomDTO>> GetHotelRoom(int roomId)
        {
            throw new NotImplementedException();
        }

        public Task<HotelRoomDTO> IsSameNameRoomAlreadyPresent(string name)
        {
            throw new NotImplementedException();
        }

        public Task<HotelRoomDTO> UpdateHotelRoom(HotelRoomDTO hotelRoomDTO, int roomId)
        {
            throw new NotImplementedException();
        }
    }
}
