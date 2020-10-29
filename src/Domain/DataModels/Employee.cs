using DotNetCms.Domain.Common;
using System.Collections.Generic;

namespace DotNetCms.Domain.DataModels
{
    public class Employee: AuditableEntity
    {
        public int Id { get; set; }
        public byte[] Photo { get; set; }
        public int PossitionId { get; set; }
        public Possition Possition { get; set; }
        public int HumanId { get; set; }
        public Human Human { get; set; }

        public List<Contact> Contacts { get; set; }
        public List<SocialNetwork> SocialNetworks { get; set; }

    }
    
}