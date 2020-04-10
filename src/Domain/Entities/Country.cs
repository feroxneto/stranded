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
            CitizenList = new List<Citizen>();
            LockedOutCitizenList = new List<Citizen>();
            NextOfKinList = new List<NextOfKin>();
        }   
        
        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public IList<City> CityList { get; set; }
        public IList<Institution> InstitutionList { get; set; }
        public IList<Citizen> CitizenList { get; set; }
        public IList<Citizen> LockedOutCitizenList { get; set; }
        public IList<NextOfKin> NextOfKinList { get; set; }

    }
}
