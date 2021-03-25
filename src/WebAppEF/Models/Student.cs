using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppSP.Models
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudentId { get; set; }

        public int TenantId { get; set; }

        public string StudentName { get; set; }

        public Tenant School { get; set; }

        public ICollection<Course> Classes { get; set; }
    }
}
