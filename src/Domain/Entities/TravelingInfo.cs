using CleanArchitecture.Domain.Common;
using CleanArchitecture.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Domain.Entities
{
    public class TravelingInfo : AuditableEntity
    { 
        public long Id { get; set; }
        public long CitizenId { get; set; }
        public bool HasValidAirlineTicket { get; set; }
        public string AirlineName { get; set; }
        public Nullable<DateTime> OriginalReturnDate { get; set; }
        public Nullable<long> CityOfDestinyId { get; set; }
        public City CityOfDestiny { get; set; }

        public Citizen Citizen { get; set; }



    }
}
