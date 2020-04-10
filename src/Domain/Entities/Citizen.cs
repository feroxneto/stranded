using CleanArchitecture.Domain.Common;
using CleanArchitecture.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Domain.Entities
{
    public class Citizen : AuditableEntity
    {
        public Citizen()
        {
            AttachmentList = new List<Attachment>();
            NextOfKinList = new List<NextOfKin>();
        }
        public long Id { get; set; } 
        public string Name { get; set; } //c
        public string Surname { get; set; }//c
        public DateTime DOB { get; set; }
        public int Age { get => (int) ((DateTime.Now - DOB).TotalDays / 365.242199); }
        public Gender Gender { get; set; }
        public string DocumentNumber { get; set; }
        public long CitizenshipTypeId { get; set; }
        public long DocumentTypeId { get; set; }
        public long CountryId { get; set; }

        public long HealthStatusId { get; set; }
        public long StrandedId { get; set; }

        public Nullable<long> VisitPurposeId { get; set; }
        public Nullable<long> LockOutCountryId { get; set; }
        public Nullable<long> LockOutCityId { get; set; }


        public LockOutStatus LockOutStatus { get; set; }
        public string PhoneNumber { get; set; }
        public string PhoneNumberOther { get; set; }
        public string Email { get; set; }
        public string CurrentAddress { get; set; }
        public string PermanentResidenceAddress { get; set; }
        public bool IsVerified { get; set; }

        public string CitizenComment { get; set; }
        public string AdminPublicComment { get; set; }
        public string AdminInternalComment { get; set; }

        public CitizenshipType CitizenshipType { get; set; }
        public DocumentType DocumentType { get; set; }
        public Country Country { get; set; }
        public HealthStatus HealthStatus { get; set; }
        public Stranded Stranded { get; set; }
        public TravelingInfo TravelingInfo { get; set; }
        public VisitPurpose VisitPurpose { get; set; }

        public Country LockOutCountry { get; set; }
        public City LockOutCity { get; set; }

        public IList<Attachment> AttachmentList { get; set; }
        public IList<NextOfKin> NextOfKinList { get; set; }

        public bool IsActive { get; set; }


    }
}
