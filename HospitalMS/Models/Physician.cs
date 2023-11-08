using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HospitalMS.Models
{
    public class Physician
    {
        [Key]
        public int PhysicianId { get; set; }

        [Required]
        public string Firstname { get; set; }

        [Required]
        public string Lastname { get; set; }

        public List<Specialty> Specialties { get; set; }

        public DateTime DateOfHire { get; set; }
    }
}
