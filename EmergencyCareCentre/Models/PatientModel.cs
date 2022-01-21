using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EmergencyCareCentre.Models
{
    public class PatientModel
    {
        [Key]
        [Required]
        [MaxLength(10), MinLength(7)] // Allow for future growth and enforce min
        public string URN { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Required] 
        public string FirstName { get; set; }
        [Required] 
        public string Surname { get; set; }
        [Required]
        public DateTime Admitted { get; set; }
        public DateTime? Discharged { get; set; }
        public List<CommentModel> Comments { get; set; }
        public string PresentingIssue { get; set; }
        
        // Keep track of patients last updated statuses for tracking and QA
        public DateTime AssignedBedLastUpdated { get; set; }

        public DateTime PresentingIssueLastUpdated { get; set; }
    }
}
