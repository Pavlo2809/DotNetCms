using DotNetCms.Core.Abstractions.Repositories;
using DotNetCms.Domain.DataModels;

namespace DotNetCms.DataLayer.Repositories
{
    public class SocialNetworkRepository : BaseRepository<int, SocialNetwork, SocialNetworkRepository>, ISocialNetworkRepository
    {
        public SocialNetworkRepository(DotNetCMSContext context) : base(context)
        { }

        ISocialNetworkRepository IBaseRepository<int, SocialNetwork, ISocialNetworkRepository>.NoTrack()
        {
            return base.NoTrack();
        }

        ISocialNetworkRepository IBaseRepository<int, SocialNetwork, ISocialNetworkRepository>.Reset()
        {
            return base.Reset();
        }

    }
}