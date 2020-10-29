using DotNetCms.Core.Abstractions.Repositories;
using DotNetCms.Domain.DataModels;

namespace DotNetCms.DataLayer
{
    public class PossitionRepository : BaseRepository<int, Possition, PossitionRepository>, IPossitionRepository
    {
        public PossitionRepository(DotNetCMSContext context) : base(context)
        { }

        IPossitionRepository IBaseRepository<int, Possition, IPossitionRepository>.NoTrack()
        {
            return base.NoTrack();
        }

        IPossitionRepository IBaseRepository<int, Possition, IPossitionRepository>.Reset()
        {
            return base.Reset();
        }

    }
}