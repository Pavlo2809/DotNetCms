using DotNetCms.Core.Abstractions.Repositories;
using DotNetCms.Domain.DataModels;

namespace DotNetCms.DataLayer
{
    public class CarouselItemRepository : BaseRepository<int, CarouselItem, CarouselItemRepository>, ICarouselItemRepository
    {
        public CarouselItemRepository(DotNetCMSContext context) : base(context)
        { }

        ICarouselItemRepository IBaseRepository<int, CarouselItem, ICarouselItemRepository>.NoTrack()
        {
            return base.NoTrack();
        }

        ICarouselItemRepository IBaseRepository<int, CarouselItem, ICarouselItemRepository>.Reset()
        {
            return base.Reset();
        }

    }
}