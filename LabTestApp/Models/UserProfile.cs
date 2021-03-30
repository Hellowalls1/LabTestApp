using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LabTestApp.Models
{
    public class UserProfile
    {
        //User would be a doctor/nurse
        //User will be able to view patients and patients tests. 
        //Can be assigned a patient
        
        public int Id { get; set; }

         [Required]
        [MaxLength(50)]
         public string FirebaseUserId { get; set; }

     

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }


        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }


        [Required]
        [DataType(DataType.EmailAddress)]
        [MaxLength(255)]
        public string Email { get; set; }
    }
}