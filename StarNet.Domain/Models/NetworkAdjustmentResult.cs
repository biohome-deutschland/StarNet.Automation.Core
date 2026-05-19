namespace StarNet.Domain.Models
{
    /// <summary>
    /// Repräsentiert das Resultat einer Netzausgleichung,
    /// abgeleitet aus einer .lst-Datei.
    /// </summary>
    public class NetworkAdjustmentResult
    {
        public bool IsSuccessful { get; set; }
        // TODO: Weitere Eigenschaften für standardisierte Residuen ergänzen
    }
}
