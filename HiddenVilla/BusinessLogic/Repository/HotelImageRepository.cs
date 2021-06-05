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
    public class HotelImageRepository : IHotelImageRepository
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;

        public HotelImageRepository(ApplicationDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<int> CreateHotelRoomImage(HotelRoomImageDTO imageDTO)
        {
            var image = _mapper.Map<HotelRoomImageDTO, HotelRoomImage>(imageDTO);
            await _dbContext.HotelRoomImages.AddAsync(image);
            return await _dbContext.SaveChangesAsync();
        }

        public async Task<int> DeleteHotelRoomImageByImageId(int imageId)
        {
            var image = await _dbContext.HotelRoomImages.FindAsync(imageId);
            _dbContext.HotelRoomImages.Remove(image);
            return await _dbContext.SaveChangesAsync();
        }

        public async Task<int> DeleteHotelRoomImageByImageUrl(string imageUrl)
        {
            var allImages = await _dbContext.HotelRoomImages.FirstOrDefaultAsync(x => x.RoomImageUrl.ToLower() == imageUrl.ToLower());

            if(allImages == null)
            {
                return 0;
            }

            _dbContext.HotelRoomImages.Remove(allImages);
            return await _dbContext.SaveChangesAsync();
        }

        public async Task<int> DeleteHotelRoomImageByRoomId(int roomId)
        {
            var imageList = await _dbContext.HotelRoomImages.Where(x => x.RoomId == roomId).ToListAsync();
            _dbContext.HotelRoomImages.RemoveRange(imageList);
            return await _dbContext.SaveChangesAsync();

        }

        public async Task<IEnumerable<HotelRoomImageDTO>> GetHotelRoomImagesByRoomId(int roomId)
        {
            return _mapper.Map<IEnumerable<HotelRoomImage>,IEnumerable<HotelRoomImageDTO>>(
                await _dbContext.HotelRoomImages.Where(x => x.RoomId == roomId).ToListAsync()
            );
        }
    }
}
