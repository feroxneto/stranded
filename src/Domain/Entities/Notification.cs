using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Domain.Entities
{
    public class Notification
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }

        public DateTime? PublishedDate { get; set; }
        public bool IsActive { get; set; }
    }
}
