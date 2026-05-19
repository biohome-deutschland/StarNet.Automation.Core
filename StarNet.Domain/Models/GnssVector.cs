namespace StarNet.Domain.Models
{
    /// <summary>
    /// Repräsentiert einen GNSS-Basislinienvektor (G-Zeile in STAR*NET).
    /// </summary>
    public class GnssVector : Observation
    {
        public double DeltaX { get; set; }
        public double DeltaY { get; set; }
        public double DeltaZ { get; set; }
    }
}
