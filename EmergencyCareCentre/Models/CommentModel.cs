using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EmergencyCareCentre.Models
{
    public class CommentModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public PatientModel Patient { get; set; }
        
        // In a more-developed app Nurse would be a more customised object
        // and differentiate from other login users
        [Required]
        public ApplicationUser Nurse { get; set; }

        [Required]
        public DateTime Created { get; set; }
    }
}
