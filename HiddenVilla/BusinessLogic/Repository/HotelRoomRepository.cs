using AutoMapper;
using Business.Repository.IRepository;
using DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repository
{
    public class HotelRoomRepository : IHotelRoomRepository
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;

        public HotelRoomRepository(ApplicationDbContext applicationDbContext, IMapper mapper)
        {
            _dbContext = applicationDbContext;
            _mapper = mapper;
        }

        public async Task<HotelRoomDTO> CreateHotelRoom(HotelRoomDTO hotelRoomDTO)
        {
            HotelRoom hotelRoom = _mapper.Map<HotelRoomDTO, HotelRoom>(hotelRoomDTO);
            hotelRoom.CreatedDate = DateTime.Now;
            hotelRoom.CreatedBy = string.Empty;

            var addedHotelRoom = await _dbContext.HotelRooms.AddAsync(hotelRoom);

            await _dbContext.SaveChangesAsync();

            return _mapper.Map<HotelRoom, HotelRoomDTO>(addedHotelRoom.Entity);
        }

        public async Task<IEnumerable<HotelRoomDTO>> GetAllHotelRooms()
        {
            try
            {
                IEnumerable<HotelRoomDTO> hotelRoomDTOs = 
                    _mapper.Map<IEnumerable<HotelRoom>, IEnumerable<HotelRoomDTO>> (_dbContext.HotelRooms.Include(y => y.HotelRoomImages));

                return hotelRoomDTOs;
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        public async Task<HotelRoomDTO> GetHotelRoom(int roomId)
        {
            try
            {
                //return _mapper.Map<HotelRoom, HotelRoomDTO>(await _dbContext.HotelRooms.FirstOrDefaultAsync(x => x.Id == roomId));

                HotelRoomDTO hotelRoom = _mapper.Map<HotelRoom,HotelRoomDTO>(
                        await _dbContext.HotelRooms.Include(y => y.HotelRoomImages).FirstOrDefaultAsync(x => x.Id == roomId)
                    );

                return hotelRoom;
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public async Task<HotelRoomDTO> IsRoomUnique(string name, int roomId = 0)
        {
            try
            {
                if (roomId == 0)
                {
                    HotelRoomDTO hotelRoom = _mapper.Map<HotelRoom, HotelRoomDTO>(
                        await _dbContext.HotelRooms.FirstOrDefaultAsync(x => x.Name.ToLower() == name.ToLower()));

                    return hotelRoom;
                }
                else
                {
                    HotelRoomDTO hotelRoom = _mapper.Map<HotelRoom, HotelRoomDTO>(
                        await _dbContext.HotelRooms.FirstOrDefaultAsync(x => x.Name.ToLower() == name.ToLower()
                        && x.Id != roomId));

                    return hotelRoom;
                }
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        public async Task<HotelRoomDTO> UpdateHotelRoom(HotelRoomDTO hotelRoomDTO, int roomId)
        {
            try
            {
                if (roomId == hotelRoomDTO.Id)
                {
                    HotelRoom roomDetails = await _dbContext.HotelRooms.FindAsync(roomId);
                    HotelRoom room = _mapper.Map(hotelRoomDTO, roomDetails);
                    room.UpdatedBy = string.Empty;
                    room.UpdatedDate = DateTime.Now;
                    var updateRoom = _dbContext.HotelRooms.Update(room);
                    await _dbContext.SaveChangesAsync();
                    return _mapper.Map<HotelRoom, HotelRoomDTO>(updateRoom.Entity);
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<int> DeleteHotelRoom(int roomId)
        {
            var roomDetails = await _dbContext.HotelRooms.FindAsync(roomId);
            if (roomDetails != null)
            {
                var allImages = await _dbContext.HotelRoomImages.Where(x => x.RoomId == roomId).ToListAsync();

                _dbContext.HotelRoomImages.RemoveRange(allImages);
                _dbContext.HotelRooms.Remove(roomDetails);
                return await _dbContext.SaveChangesAsync();
            }

            return 0;
        }
    }
}
