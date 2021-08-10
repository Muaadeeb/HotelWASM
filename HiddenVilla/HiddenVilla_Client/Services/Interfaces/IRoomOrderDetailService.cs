using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HiddenVilla_Client.Services.Interfaces
{
    public interface IRoomOrderDetailService
    {
        public Task<RoomOrderDetailDTO> SaveRoomOrderDetailAsync(RoomOrderDetailDTO details);
        public Task<RoomOrderDetailDTO> MarkPaymentSuccessful(RoomOrderDetailDTO details);
    }
}
