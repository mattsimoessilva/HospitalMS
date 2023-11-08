using HospitalMS.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Discharge
{
    [Key]
    public int DischargedId { get; set; }

    [Required]
    [ForeignKey("Patient")]
    public int PatientId { get; set; }

    public Patient Patient { get; set; }

    [Required]
    [StringLength(500)]
    public string Details { get; set; }
}
