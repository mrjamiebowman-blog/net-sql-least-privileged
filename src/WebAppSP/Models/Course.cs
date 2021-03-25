using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppSP.Models
{
    public class Course
    {
        public int? TenantId { get; set; }

        public int? SchoolClassId { get; set; }

        public string ClassName { get; set; }
    }
}
