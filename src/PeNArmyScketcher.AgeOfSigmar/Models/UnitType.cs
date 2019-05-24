using Newtonsoft.Json;
using PeNArmyScketcher.AgeOfSigmar.Converters;

namespace PeNArmyScketcher.AgeOfSigmar
{
    [JsonConverter(typeof(UnitTypeJsonConverter))]
    public enum UnitType
    {
        Unit = 0,
        Artillery,
        Battleline,
        Leader,
        Unique
    }
}