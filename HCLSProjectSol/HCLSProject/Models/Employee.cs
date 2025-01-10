using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HCLSProject.Models
{
    [Table("Employee")]
    public class Employee
    {
        [Key]
        [Required(ErrorMessage = "Please Enter Employee Id")]
        public int EmpId { get; set; }

        [Required(ErrorMessage = "Please Enter Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please Enter Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }

        [Required(ErrorMessage = "Please Enter Date of Joining")]
        [DataType(DataType.Date)]
        public DateTime DOJ { get; set; }

        [Required(ErrorMessage = "Please Enter Phone")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please Enter Email")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please Enter Password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please Enter Salary")]
        public decimal Salary { get; set; }

        [Required(ErrorMessage = "Please Enter Address")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please Specify Active Status")]
        public bool Active { get; set; }

        [ForeignKey("Department")]
        [Required(ErrorMessage = "Please Enter Department Number")]
        public int DeptNo { get; set; }

        public Department? Department { get; set; }
    }
}
