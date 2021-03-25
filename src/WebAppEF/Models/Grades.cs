using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebAppEF.Enums;

namespace WebAppSP.Models
{
    public class Grades
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int GradeId { get; set; }

        public int StudentId { get; set; }

        public int SchoolClassId { get; set; }

        /// <summary>
        /// A, B, C, D, F
        /// </summary>
        public Grade? Grade { get; set; }
    }
}
