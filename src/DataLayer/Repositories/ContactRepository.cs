using DotNetCms.Core.Abstractions.Repositories;
using DotNetCms.Domain.DataModels;

namespace DotNetCms.DataLayer.Repositories
{
    public class ContactRepository : BaseRepository<int, Contact, ContactRepository>, IContactRepository
    {
        public ContactRepository(DotNetCMSContext context) : base(context)
        { }

        IContactRepository IBaseRepository<int, Contact, IContactRepository>.NoTrack()
        {
            return base.NoTrack();
        }

        IContactRepository IBaseRepository<int, Contact, IContactRepository>.Reset()
        {
            return base.Reset();
        }

    }
}