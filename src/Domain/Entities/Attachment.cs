using CleanArchitecture.Domain.Common;
using CleanArchitecture.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Domain.Entities
{
    public class Attachment : AuditableEntity
    {
        public long Id { get; set; }
        public string Description { get; set; }
        public long CitizenId { get; set; }
        public byte[] Picture { get; set; }
        public Citizen Citizen { get; set; }
        public AttachmentType AttachmentType { get; set; }
    }
}
