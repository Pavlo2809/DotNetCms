using DotNetCms.Domain.Common;

namespace DotNetCms.Domain.DataModels
{
    public class CarouselItem: AuditableEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public byte[] BackgroundImage { get; set; }
    }
}