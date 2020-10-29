using DotNetCms.Core.Abstractions.Repositories;
using DotNetCms.Domain.DataModels;

namespace DotNetCms.DataLayer
{
    public class ServiceRepository : BaseRepository<int, Service, ServiceRepository>, IServiceRepository
    {
        public ServiceRepository(DotNetCMSContext context) : base(context)
        { }

        IServiceRepository IBaseRepository<int, Service, IServiceRepository>.NoTrack()
        {
            return base.NoTrack();
        }

        IServiceRepository IBaseRepository<int, Service, IServiceRepository>.Reset()
        {
            return base.Reset();
        }

    }
}