namespace run4cause.Models
{
    public class Sponsorship
    {
        public int Id { get; set; }

        public float AmountPerkilometer { get; set; }

        public User? Sponsor { get; set; }
        public User? Performer { get; set; }
    }
}
