using System.Collections.Generic;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MiniProject.Models

{
    public class User
    {
       
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }
        [Required(ErrorMessage ="Please Enter the Field")]
        [MaxLength(30),MinLength(3)]
        [DataType(DataType.Text)]
        public string LogInName { get; set; }
        [DataType(DataType.Password)]
        [MaxLength(8),MinLength(3)]
        [Required(ErrorMessage ="Please Enter Password")]
        
        public string Password { get; set; }
        [System.ComponentModel.DataAnnotations.Compare("Password")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
        [DataType(DataType.Text)]
        [StringLength(30,ErrorMessage ="{0} should not greater than {1} and less than {2}",MinimumLength =5)]
        public string FullName { get; set; }
       [EmailAddress]
       [Display(Name ="Email Address")]
        public string EmailId { get; set; }
        [DataType(DataType.Currency)]

        public int CityId { get; set; }

        public IEnumerable<SelectListItem> Cities { get; set; }
        public string Phone { get; set; }

        public bool IsActive { get; set; }
    }
}