using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppSP.Models
{
    public class Grades
    {
        public int? SchoolClassId { get; set; }

        public int? GradeId { get; set; }

        public int? StudentId { get; set; }

        /// <summary>
        /// A, B, C, D, F
        /// </summary>
        public string Grade { get; set; }
    }
}
