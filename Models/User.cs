using System.ComponentModel.DataAnnotations;

namespace run4cause.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [MaxLength(16)]
        public string? PhoneNumber { get; set; }

        [Required, MaxLength(320)] // RFC : https://datatracker.ietf.org/doc/html/rfc3696#section-3
        public string Email { get; set; }

        public float TotalDistanceCovered { get; set; }

        public List<Entry>? Entries { get; set; }

        public List<Tracking>? Trackings { get; set; }
    }
}
