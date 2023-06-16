using System.ComponentModel.DataAnnotations;


namespace StarSecurity.Models
{
    public class Services
    {
        public int ServicesId { get; set; }

        [Required]
        [Display(Name = "Service Name")]
        [StringLength(25)]
        public string ServiceName { get; set; }

        [Required]
        [Display(Name = "Service Details")]
        [StringLength(25)]
        public string ServiceDetail { get; set; }

        [Required]
        [Display(Name = "Sub-Service Name")]
        [StringLength(25)]
        public string SubServiceName { get; set; }

        [Required]
        [Display(Name = "Sub-Service Details")]
        [StringLength(25)]
        public string SubServiceDetail { get; set; }

        [Required]
        [Display(Name = "Service Fees")]
        public int ServiceFee { get; set; }

    }
}
