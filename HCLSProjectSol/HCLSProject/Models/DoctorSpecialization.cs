using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HCLSProject.Models
{
    [Table("DoctorSpecialization")]
    public class DoctorSpecialization
    {
        [Key]
        [Required(ErrorMessage = "Please Enter Employee Id")]
        public int DocSpecId { get; set; }

        [Required(ErrorMessage = "Please Enter Specialization")]
        public string Specialization { get; set; }
    }
}
