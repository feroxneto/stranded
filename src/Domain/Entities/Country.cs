using CleanArchitecture.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Domain.Entities
{
    public class Country : AuditableEntity
    {
        public Country()
        {
            CityList = new List<City>();
            InstitutionList = new List<Institution>();
        }   
        
        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public IList<City> CityList { get; set; }
        public IList<Institution> InstitutionList { get; set; }

    }
}
