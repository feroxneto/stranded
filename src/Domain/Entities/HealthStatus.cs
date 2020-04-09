using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Domain.Entities
{
    public class HealthStatus
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
    }
}
