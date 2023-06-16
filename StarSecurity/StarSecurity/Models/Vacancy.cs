using System.ComponentModel.DataAnnotations;

namespace StarSecurity.Models
{
    public class Vacancy
    {
        public int VacancyId { get; set; }

        [Required]
        [Display(Name = "Vacancy Topic")]
        [StringLength(25)]
        public string VacancyTopic { get; set; }

        [Required]
        [Display(Name = "Vacancy Type")]
        [StringLength(25)]
        public string VacancyType { get; set; }

        [Required]
        [Display(Name = "Time Period")]
        [StringLength (25)]
        public string TimePeriod { get; set; }

        [Required]
        [StringLength(25)]
        public string Gender { get; set; }

        [Required]
        [StringLength(25)]
        public string Qualification { get; set; }

        [Required]
        [StringLength(1000)]
        public string Description { get; set; }
    }
}
