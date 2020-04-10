using CleanArchitecture.Domain.Common;
using CleanArchitecture.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Domain.Entities
{
    public class NextOfKin : AuditableEntity
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public long CitizenId { get; set; }
        public Nullable<long> RelationshipTypeId { get; set; } 
        public Nullable<long> CountryId { get; set; }
        public string PhoneNumber { get; set; }
        public string PhoneNumberOther { get; set; }
        public string Email { get; set; }

        public Country Country { get; set; }
        public Citizen Citizen { get; set; }
        public RelationshipType RelationshipType { get; set; }
        public bool IsActive { get; set; }


    }
}
