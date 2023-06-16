using System.ComponentModel.DataAnnotations;

namespace StarSecurity.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        [Required]
        [Display(Name = "Employee Name")]
        [MaxLength(20, ErrorMessage = "Maximum 20 Characters Allowed")]
        [MinLength(3, ErrorMessage = "Minimum 3 characters Required")]
        public string EName { get; set; }

        [Required]
        [Display(Name = "Address")]
        public string EAddress { get; set; }

        [Required]
        [Display(Name = "Number")]
        public int ENumber { get; set; }

        [Required]
        [Display(Name = "Qualification")]
        public string EQualification { get; set; }

        [Required]
        [Display(Name = "Code")]
        public string ECode { get; set; }

        [Required]
        [Display(Name = " Department ")]
        public string EDepartment { get; set; }

        [Required]
        [Display(Name = " Role")]
        public string ERole { get; set; }

        [Required]
        [Display(Name = "Grade")]
        public string EGrade { get; set; }

        [Required]
        [Display(Name = "Clients")]
        public int EClients { get; set; }

        [Display(Name = "Achievements")]
        public string EAchievements { get; set; }
    }
}
