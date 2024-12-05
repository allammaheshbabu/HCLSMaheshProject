using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HCLSProject.Models
{
    [Table("Admin")]
    public class Admin
    {
        [Key]
        [Required(ErrorMessage = "Please Enter AdminId")]
        public int AdminId { get; set; }

        [Required(ErrorMessage = "Please Enter AdminName")]
        public string AdminName { get; set; }

        [Required(ErrorMessage = "Please Enter Gender")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Please Enter Phone")]
        public long Phone { get; set; }

        [Required(ErrorMessage = "Please Enter Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please Enter Password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please Enter Address")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please Enter Id_Proof")]
        public string Id_Proof { get; set; }

        [Required(ErrorMessage = "Please Enter ActiveStatus")]
        public bool ActiveStatus { get; set; }

        [ForeignKey("AdminTypes")] 
        [Required(ErrorMessage = "Please Enter AdminTypeId")]
        public int AdminTypeId { get; set; }

      
        public  AdminTypes AdminType { get; set; } 
    }

}
