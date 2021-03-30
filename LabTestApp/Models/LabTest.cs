using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LabTestApp.Models
{
    public class LabTest
    {
        //Lab tests can be assigned to patient
        public int Id { get; set; }

        [Required]
        public int PatientId { get; set; }

        public Patient Patient { get; set; }


        [Required]
        [MaxLength(75)]
        public string TestType{ get; set; }


        [Required]
        [MaxLength(500)]
        public string TestResult { get; set; }


        [Required]
        [MaxLength(50)]
        public DateTime TestTime{ get; set; }

        [Required]
        [MaxLength(255)]
        public DateTime EnteredTime { get; set; }

    }

}

