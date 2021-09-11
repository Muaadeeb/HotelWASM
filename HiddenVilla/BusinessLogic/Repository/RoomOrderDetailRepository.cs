using AutoMapper;
using Business.Repository.IRepository;
using DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repository
{
    public class RoomOrderDetailRepository : IRoomOrderDetailRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public RoomOrderDetailRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<RoomOrderDetailDTO> CreateAsync(RoomOrderDetailDTO details)
        {
            try
            {
                details.CheckInDate = details.CheckInDate.Date;
                details.CheckOutDate = details.CheckOutDate.Date;

                var roomOrder = _mapper.Map<RoomOrderDetailDTO, RoomOrderDetail>(details);
                roomOrder.Status = Common.StaticDetails.Status_Pending;
                var result = await _context.RoomOrderDetails.AddAsync(roomOrder);
                await _context.SaveChangesAsync();
                return _mapper.Map<RoomOrderDetail, RoomOrderDetailDTO>(result.Entity);
            }
            catch(Exception ex)
            {
                return default;
            }
        }

        public async Task<IEnumerable<RoomOrderDetailDTO>> GetAllRoomOrderDetailsAsync()
        {
            try
            {
                IEnumerable<RoomOrderDetailDTO> roomOrders = _mapper.Map<IEnumerable<RoomOrderDetail>, IEnumerable<RoomOrderDetailDTO>>(_context.RoomOrderDetails.Include(x => x.HotelRoom));
                return roomOrders;
            }
            catch(Exception ex)
            {
                return default;
            }
        }

        public async Task<RoomOrderDetailDTO> GetRoomOrderDetailAsync(int roomOrderId)
        {
            try
            {
                RoomOrderDetail roomOrder = await _context.RoomOrderDetails
                    .Include(u => u.HotelRoom)
                    .ThenInclude(x => x.HotelRoomImages)
                    .FirstOrDefaultAsync(u => u.Id == roomOrderId);

                RoomOrderDetailDTO roomOrderDetailDTO = _mapper.Map<RoomOrderDetail, RoomOrderDetailDTO>(roomOrder);
                roomOrderDetailDTO.HotelRoomDTO.TotalDays = roomOrderDetailDTO.CheckOutDate.Subtract(roomOrderDetailDTO.CheckInDate).Days;

                return roomOrderDetailDTO;
            }
            catch (Exception ex)
            {
                return default;
            }
        }



        public async Task<RoomOrderDetailDTO> MarkPaymentSuccessfulAsync(int id)
        {
            var data = await _context.RoomOrderDetails.FindAsync(id);

            if (data == null)
            {
                return null;
            }

            if (!data.IsPaymentSuccessful)
            {
                data.IsPaymentSuccessful = true;
                data.Status = Common.StaticDetails.Status_Booked;
                var markPaymentSuccessful = _context.RoomOrderDetails.Update(data);
                await _context.SaveChangesAsync();
                return _mapper.Map<RoomOrderDetail, RoomOrderDetailDTO>(markPaymentSuccessful.Entity);

            }

            // TODO: why return empty object vs null...do we have an error here...do it better.
            return new RoomOrderDetailDTO();

        }

        public Task<bool> UpdateOrderStatusAsync(int roomOrderId, string status)
        {
            throw new NotImplementedException();
        }
    }
}
