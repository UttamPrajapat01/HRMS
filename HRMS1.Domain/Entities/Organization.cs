using System;
using System.Collections.Generic;
// Using this Class Gate all Organization related information
namespace HRMS.Domain.Entities
{
    public class Organization
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }
        public string CreatedByUserId { get; set; }


    }
}
