using DotNetCms.Core.Abstractions.Repositories;
using DotNetCms.Domain.DataModels;

namespace DotNetCms.DataLayer
{
    public class TariffRepository : BaseRepository<int, Tariff, TariffRepository>, ITariffRepository
    {
        public TariffRepository(DotNetCMSContext context) : base(context)
        { }

        ITariffRepository IBaseRepository<int, Tariff, ITariffRepository>.NoTrack()
        {
            return base.NoTrack();
        }

        ITariffRepository IBaseRepository<int, Tariff, ITariffRepository>.Reset()
        {
            return base.Reset();
        }

    }
}