using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HCLSProject.Models
{
    [Table("LabDetails")]
    public class LabDetails
    {
        [Key]
        [Required(ErrorMessage = "Please Enter Employee Id")]
        public int EmpId { get; set; }

        [Required(ErrorMessage = "Please Enter Email")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please Enter Logged")]
        public Boolean Logged { get; set; }
    }
}
