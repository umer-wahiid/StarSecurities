﻿using System.ComponentModel.DataAnnotations;

namespace StarSecurity.Models
{
    public class Client
    {
        public int ClientId { get; set; }

        [Required]
        [Display(Name = "Client Name")]
        [StringLength(25)]
        public string ClientName { get; set; }


        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

        //[Required]
        //[Display(Name = "Staff Asign")]
        //[StringLength(100)]
        //public string StaffAsign { get; set; }

        public int ServicesId { get; set; }
        public Services Services { get; set; }
    }
}
