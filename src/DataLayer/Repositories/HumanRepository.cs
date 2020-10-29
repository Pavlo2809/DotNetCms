using DotNetCms.Core.Abstractions.Repositories;
using DotNetCms.Domain.DataModels;

namespace DotNetCms.DataLayer.Repositories
{
    public class HumanRepository : BaseRepository<int, Human, HumanRepository>, IHumanRepository
    {
        public HumanRepository(DotNetCMSContext context) : base(context)
        { }

        IHumanRepository IBaseRepository<int, Human, IHumanRepository>.NoTrack()
        {
            return base.NoTrack();
        }

        IHumanRepository IBaseRepository<int, Human, IHumanRepository>.Reset()
        {
            return base.Reset();
        }

    }
}