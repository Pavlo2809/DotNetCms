using DotNetCms.Domain.Common;
using DotNetCms.Domain.Enums;

namespace DotNetCms.Domain.DataModels
{
    public class Contact: AuditableEntity
    {
        public int Id { get; set; }
        public ContactType Type{ get; set; }
        public string Value { get; set; }
    }
}