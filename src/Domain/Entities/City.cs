using CleanArchitecture.Domain.Common;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.Entities
{
    public class City : AuditableEntity
    {
        public City()
        {
            InstitutionList = new List<Institution>();
        }
        public long Id { get; set; }
        public string Name { get; set; }
        public long CountryId { get; set; } 
        public bool IsActive { get; set; }
        public Country Country { get; set; }
        public IList<Institution> InstitutionList { get; set; }
    }
}