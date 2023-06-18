using System.ComponentModel.DataAnnotations;

namespace StarSecurity.Models
{
    public class Testimonials
    {
        public int TestimonialsId { get; set; }

        [StringLength(50)]
        [Required]
        [Display(Name = "Testimonial Name")]
        public string TName { get; set; }

        [StringLength(50)]
        [Required]
        [Display(Name = "Testimonial Profession")]
        public string TProfession { get; set; }

        [StringLength(1000)]
        [Required]
        [Display(Name = "Testimonial Image")]
        public string TImage { get; set; }

        [StringLength(1000)]
        [Required]
        [Display(Name = "Testimonial Description")]
        public string TDescription { get; set; }
    }
}
