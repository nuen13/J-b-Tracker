
/* 
    enum: A list of fix values
        - doing it this way -> only allow user to pick 1 of these value.    

*/

using Microsoft.AspNetCore.Identity;

namespace JobTrackerApp.Models
{
    public enum ApplicationStatus
    {
        Submitted, 
        NoHope, 
        Responded,
        Accepted, 
        Interviewed, 
        Negotiating,
        Rejected, 
        Withdrawn,
        
    }

    public class JobApplication
    {
        // Global Unique Identifier (unique ID)
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Position { get; set; } = string.Empty;
        public string Company { get; set; } = string.Empty;
        public string Industry { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public DateTime? DatePosted { get; set; } = DateTime.Now;
        public DateTime? DateApplied { get; set; } = DateTime.Now;
        public string Connections { get; set; } = string.Empty;
        public bool HasCoverLetter {get; set; }
        public bool HasResumeForm { get; set; }
        public string SalaryRange { get; set; } = string.Empty;
        public string Notes { get; set; } = string.Empty;
        public ApplicationStatus Status { get; set; } = ApplicationStatus.Submitted;
        public string LatestContactName { get; set; } = string.Empty;

        public string AppliedLink {get; set;} = string.Empty;

    }
}



