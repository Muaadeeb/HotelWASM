using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repository.IRepository
{
    public interface IRoomOrderDetailRepository
    {
        public Task<RoomOrderDetailDTO> CreateAsync(RoomOrderDetailDTO details);
        public Task<RoomOrderDetailDTO> MarkPaymentSuccessfulAsync(int id); // ?? roomOrderId
        public Task<RoomOrderDetailDTO> GetRoomOrderDetailAsync(int roomOrderId);
        public Task<IEnumerable<RoomOrderDetailDTO>> GetAllRoomOrderDetailsAsync();
        public Task<bool> UpdateOrderStatusAsync(int roomOrderId, string status);
        
    }
}
