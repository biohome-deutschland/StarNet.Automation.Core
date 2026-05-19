namespace StarNet.Domain.Models
{
    /// <summary>
    /// Repräsentiert einen Standpunkt (Instrumentenaufstellung).
    /// </summary>
    public class Station
    {
        public string Name { get; set; } = string.Empty;
        public double InstrumentHeight { get; set; }
    }
}
