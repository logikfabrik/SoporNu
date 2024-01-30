namespace SoporNu.Models
{
    public sealed record AvsDetails : Avs
    {
        public Service[] Services { get; init; }

        public AvsDetails(Avs original, Service[] services) : base(original)
        {
            Services = services;
        }
    }
}
