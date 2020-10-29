using DotNetCms.Domain.Common;

namespace DotNetCms.Domain.DataModels
{
    public class Service: AuditableEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int TariffId { get; set; }
        public Tariff Tariff { get; set; }
    }
}