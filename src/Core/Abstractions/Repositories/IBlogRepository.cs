
using DotNetCms.Domain.DataModels;

namespace DotNetCms.Core.Abstractions.Repositories
{
    public interface IBlogRepository: IBaseRepository<int, Blog, IBlogRepository>
    {

    }
}