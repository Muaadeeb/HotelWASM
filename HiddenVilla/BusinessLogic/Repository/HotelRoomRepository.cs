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

        public async Task<bool> ISRoomBookedAsync(int roomId, string checkInDateStr, string checkOutDateStr)
        {
            if (string.IsNullOrEmpty(checkInDateStr) || string.IsNullOrEmpty(checkOutDateStr))
            {
                throw new Exception("Bad Request - Missing date parms");
            }

            try
            {
                DateTime checkInDate = DateTime.ParseExact(checkInDateStr, "MM/dd/yyyy", null);
                DateTime checkOutDate = DateTime.ParseExact(checkOutDateStr, "MM/dd/yyyy", null);

                var existingBooking = await _dbContext.RoomOrderDetails.Where(x => x.RoomId == roomId && x.IsPaymentSuccessful &&
                                        (
                                            (checkInDate < x.CheckOutDate && checkInDate.Date >= x.CheckInDate) ||
                                            (checkOutDate.Date > x.CheckInDate.Date && checkInDate.Date <= x.CheckInDate.Date)
                                        )).FirstOrDefaultAsync();

                return existingBooking != null;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<HotelRoomDTO> CreateHotelRoomAsync(HotelRoomDTO hotelRoomDTO)
        {
            HotelRoom hotelRoom = _mapper.Map<HotelRoomDTO, HotelRoom>(hotelRoomDTO);
            hotelRoom.CreatedDate = DateTime.Now;
            hotelRoom.CreatedBy = string.Empty;

            var addedHotelRoom = await _dbContext.HotelRooms.AddAsync(hotelRoom);

            await _dbContext.SaveChangesAsync();

            return _mapper.Map<HotelRoom, HotelRoomDTO>(addedHotelRoom.Entity);
        }

        public async Task<IEnumerable<HotelRoomDTO>> GetAllHotelRoomsAsync(string checkInDate, string checkOutDate)
        {
            try
            {
                IEnumerable<HotelRoomDTO> hotelRoomDTOs = 
                    _mapper.Map<IEnumerable<HotelRoom>, IEnumerable<HotelRoomDTO>> (_dbContext.HotelRooms.Include(y => y.HotelRoomImages));


                if (!string.IsNullOrEmpty(checkInDate) && !string.IsNullOrEmpty(checkOutDate))
                {
                    foreach (HotelRoomDTO hotelRoom in hotelRoomDTOs)
                    {
                        hotelRoom.IsBooked = await ISRoomBookedAsync(hotelRoom.Id, checkInDate, checkOutDate);
                    }
                }

                return hotelRoomDTOs;
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        public async Task<HotelRoomDTO> GetHotelRoomAsync(int roomId, string checkInDate, string checkOutDate)
        {
            try
            {
                //return _mapper.Map<HotelRoom, HotelRoomDTO>(await _dbContext.HotelRooms.FirstOrDefaultAsync(x => x.Id == roomId));
                HotelRoomDTO hotelRoom = _mapper.Map<HotelRoom,HotelRoomDTO>(
                        await _dbContext.HotelRooms.Include(y => y.HotelRoomImages).FirstOrDefaultAsync(x => x.Id == roomId)
                    );

                if (!string.IsNullOrEmpty(checkInDate) && !string.IsNullOrEmpty(checkOutDate))
                {
                    hotelRoom.IsBooked = await ISRoomBookedAsync(roomId, checkInDate, checkOutDate);
                }

                return hotelRoom;
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public async Task<HotelRoomDTO> IsRoomUniqueAsync(string name, int roomId = 0)
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

        public async Task<HotelRoomDTO> UpdateHotelRoomAsync(HotelRoomDTO hotelRoomDTO, int roomId)
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

        public async Task<int> DeleteHotelRoomAsync(int roomId)
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
