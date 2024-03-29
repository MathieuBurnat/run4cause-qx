using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace run4cause.Models
{
    public class User : IdentityUser<int>
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Column(TypeName = "decimal(20,2)")]
        public decimal? TotalDistanceCovered { get; set; }

        public List<Entry>? Entries { get; set; }

        public List<Tracking>? Trackings { get; set; }
    }
}
