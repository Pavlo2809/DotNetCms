using DotNetCms.Domain.Common;
using System.Collections.Generic;

namespace DotNetCms.Domain.DataModels
{
    public class Tariff: AuditableEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Service> Services { get; set; }
    }
}