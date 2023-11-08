using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HospitalMS.Models
{
    public class Country
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public ICollection<Patient> Patients { get; set; }
    }
}