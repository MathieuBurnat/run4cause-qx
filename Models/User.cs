using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace run4cause.Models
{
    public class User : IdentityUser<int>
    {
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [MaxLength(16)]
        public string? PhoneNumber { get; set; }

        public float? TotalDistanceCovered { get; set; }

        public List<Entry>? Entries { get; set; }

        public List<Tracking>? Trackings { get; set; }
    }
}
