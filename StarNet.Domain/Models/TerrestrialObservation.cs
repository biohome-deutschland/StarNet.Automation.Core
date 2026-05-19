namespace StarNet.Domain.Models
{
    /// <summary>
    /// Repräsentiert eine terrestrische Polarmessung (M-Zeile in STAR*NET).
    /// </summary>
    public class TerrestrialObservation : Observation
    {
        /// <summary>Gemessene Schrägstrecke</summary>
        public double SlopeDistance { get; set; }
        
        /// <summary>Horizontalrichtung (Azimut oder relativer Winkel)</summary>
        public double HorizontalDirection { get; set; }
        
        /// <summary>Zenitwinkel</summary>
        public double ZenithAngle { get; set; }
    }
}
