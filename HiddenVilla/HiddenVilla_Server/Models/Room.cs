using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HiddenVilla_Server.Models
{
    public class Room
    {
        public int RoomId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public bool IsActive { get; set; }
        public List<RoomProperty> RoomProperties { get; set; }

    }
}
