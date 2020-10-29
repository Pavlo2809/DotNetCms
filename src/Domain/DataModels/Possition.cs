using DotNetCms.Domain.Common;

namespace DotNetCms.Domain.DataModels
{
    public class Possition: AuditableEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Discription { get; set; }
    }
}