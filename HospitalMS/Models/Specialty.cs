using System.ComponentModel.DataAnnotations;

namespace HospitalMS.Models
{
    public class Specialty
    {

        [Key]
        public int SpecialtyId { get; set; }

        [Required]
        public string Description { get; set; }

    }
}
