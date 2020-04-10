using CleanArchitecture.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Domain.Entities
{
    public class Institution : AuditableEntity
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string PhoneNumberOther { get; set; }
        public string Email { get; set; }
        public string Note { get; set; }
        public long CountryId { get; set; }
        public Nullable<long> CityId { get; set; }
        public bool IsActive { get; set; }
        public Country Country { get; set; }
        public City City { get; set; }
    }
}
