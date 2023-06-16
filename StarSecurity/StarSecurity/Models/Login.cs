using System.ComponentModel.DataAnnotations;

namespace StarSecurity.Models

{
    public class Login
    {
        public int Id { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [MaxLength(30, ErrorMessage ="Maximum 30 Characters Allowed")]
        [MinLength(8, ErrorMessage ="Minimum 8 characters Required")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "User Name")]
        [MaxLength(20, ErrorMessage = "Maximum 20 Characters Allowed")]
        [MinLength(3, ErrorMessage = "Minimum 3 characters Required")]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [MaxLength(16, ErrorMessage = "Maximum 16 Characters Allowed")]
        [MinLength(8, ErrorMessage = "Minimum 8 characters Required")]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage ="Specified Passwords Donot Match")]
        [MaxLength(16, ErrorMessage = "Maximum 16 Characters Allowed")]
        [MinLength(8, ErrorMessage = "Minimum 8 characters Required")]
        public string CPassword { get; set; }

    }
}
