using PeNArmyScketcher.AgeOfSigmar.AllegianceAbilities;
using System.Collections.Generic;

namespace PeNArmyScketcher.AgeOfSigmar
{
    public class Faction
    {
        public string Name { get; set; }
        public Dictionary<AllegianceAbilityType, List<IAllegianceAbility>> AllegianceAbilities { get; set; }
        public List<Warscroll> Warscrolls { get; set; }
    }
}