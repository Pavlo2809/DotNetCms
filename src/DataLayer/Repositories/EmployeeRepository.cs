using DotNetCms.Core.Abstractions.Repositories;
using DotNetCms.Domain.DataModels;

namespace DotNetCms.DataLayer
{
    public class EmployeeRepository : BaseRepository<int, Employee, EmployeeRepository>, IEmployeeRepository
    {
        public EmployeeRepository(DotNetCMSContext context) : base(context)
        { }

        IEmployeeRepository IBaseRepository<int, Employee, IEmployeeRepository>.NoTrack()
        {
            return base.NoTrack();
        }

        IEmployeeRepository IBaseRepository<int, Employee, IEmployeeRepository>.Reset()
        {
            return base.Reset();
        }

    }
}