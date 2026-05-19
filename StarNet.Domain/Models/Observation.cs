namespace StarNet.Domain.Models
{
    /// <summary>
    /// Abstrakte Basisklasse für alle geodätischen Beobachtungen.
    /// </summary>
    public abstract class Observation
    {
        public Station FromStation { get; set; } = new Station();
        public Target ToTarget { get; set; } = new Target();
    }
}
