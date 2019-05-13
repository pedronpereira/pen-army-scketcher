using System.Collections.Generic;
using PeNArmyScketcher.AgeOfSigmar.Factions;
using PeNArmyScketcher.Infrastructure.Adapters;

namespace PeNArmyScketcher.AgeOfSigmar
{
    internal static class StormcastEternalsFactory
    {
        public static StormCastEternals Create(string version)
        {
            switch (version)
            {
                case "1.2018":
                default:
                    return CreateVersion12018();
            }
        }

        private static StormCastEternals CreateVersion12018()
        {
            var faction = new StormCastEternals();

            faction.AllegianceAbilities = new Dictionary<AllegianceAbilityType, List<IAllegianceAbility>>
            {
                { AllegianceAbilityType.BattleTrait, GetBattleTraits() }
            };

            return faction;
        }

        private static List<IAllegianceAbility> GetBattleTraits()
        {
            var rawData = new FileAdapter().GetData("resources/AllegianceAbilities/battle-traits-stormcast-12018.json");
            var battleTraits = new List<IAllegianceAbility>
            {

            };

            return battleTraits;
        }
    }
}
