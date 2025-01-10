using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HCLSProject.Models
{
    [Table("DoctorDetails")]
    public class DoctorDetails
    {
        [Key]
        [Required(ErrorMessage = "Please Enter Employee Id")]
        public int EmpId { get; set; }

        [Required(ErrorMessage = "Please Enter Email")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please Enter Logged")]
        public Boolean Logged { get; set; }

        [Required(ErrorMessage = "Please Enter Assigned")]
        public Boolean Assigned { get; set; }

        [ForeignKey("DoctorSpecialization")]
        [Required(ErrorMessage = "Please Enter Assigned")]
        public int DocSpecId { get; set; }

        public DoctorSpecialization? DoctorSpecialization { get; set; }
    }
}
