using DotNetCms.Domain.Common;
using DotNetCms.Domain.Enums;

namespace DotNetCms.Domain.DataModels
{
    public class SocialNetwork: AuditableEntity
    {
        public int Id { get; set; }
        public SocialNetworkType Type{ get; set; }
        public string Reference { get; set; }
    }
}