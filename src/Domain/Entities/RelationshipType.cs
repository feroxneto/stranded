using CleanArchitecture.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Domain.Entities
{
    public class RelationshipType : AuditableEntity
    {
        public RelationshipType()
        {
            NextOfKinList = new List<NextOfKin>();
        }
        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public IList<NextOfKin> NextOfKinList { get; set; }
    }
}
