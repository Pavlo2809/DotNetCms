using DotNetCms.Core.Abstractions.Repositories;
using DotNetCms.Domain.DataModels;

namespace DotNetCms.DataLayer.Repositories
{
    public class BlogRepository : BaseRepository<int, Blog, BlogRepository>, IBlogRepository
    {
        public BlogRepository(DotNetCMSContext context) : base(context)
        { }

        IBlogRepository IBaseRepository<int, Blog, IBlogRepository>.NoTrack()
        {
            return base.NoTrack();
        }

        IBlogRepository IBaseRepository<int, Blog, IBlogRepository>.Reset()
        {
            return base.Reset();
        }

    }
}