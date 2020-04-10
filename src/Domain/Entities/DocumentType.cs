﻿using CleanArchitecture.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Domain.Entities
{
    public class DocumentType : AuditableEntity
    {
        public DocumentType()
        {
            CitizenList = new List<Citizen>();
        }
        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public IList<Citizen> CitizenList { get; set; }
    }
}
