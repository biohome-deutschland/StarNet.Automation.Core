using System.Collections.Generic;
using StarNet.Domain.Models;

namespace StarNet.Domain.Interfaces
{
    /// <summary>
    /// Schnittstelle für das Einlesen proprietärer Sensordaten 
    /// (z.B. Trimble .jxml oder Leica .hexml).
    /// </summary>
    public interface ISensorParser
    {
        IEnumerable<Observation> Parse(string filePath);
    }
}
