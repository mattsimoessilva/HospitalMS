using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalMS.Models
{
    public enum Status
    {
        New,
        Confirmed,
        Cancelled
    }

    public class Appointment
    {
        [Key]
        public int AppointmentId { get; set; }

        [Required]
        [ForeignKey("Patient")]
        public int PatientID { get; set; }

        public Patient Patient { get; set; }

        [Required]
        [ForeignKey("Physician")]
        public int PhysicianId { get; set; }

        public Physician Physician { get; set; }

        public string Description { get; set; }

        public DateTime AppointmentTime { get; set; }

        public Status Status { get; set; }

        public int DurationInMinutes { get; set; }

    }
}