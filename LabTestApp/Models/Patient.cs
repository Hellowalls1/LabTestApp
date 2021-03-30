
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LabTestApp.Models
{
    public class Patient
    {
        //patients can/can not be assigned to a User (doctor or nurse)
        //UserId can be null
        public int Id { get; set; }

        public int UserProfileId { get; set; }

        public UserProfile UserProfile { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }


        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }


        [Required]
        [MaxLength(50)]
        public string Gender { get; set; }

        [Required]
        [MaxLength(75)]
        public string PatientEmail { get; set; }


        [Required]
        [MaxLength(50)]
        public string Phone { get; set; }


        [Required]
        [MaxLength(50)]
        public DateTime Birthdate { get; set; }

    }
}
