using System.Collections.Generic;
using Newtonsoft.Json;
using PeNArmyScketcher.AgeOfSigmar.AllegianceAbilities;
using PeNArmyScketcher.AgeOfSigmar.Factions;
using PeNArmyScketcher.Infrastructure.Adapters;

namespace PeNArmyScketcher.AgeOfSigmar
{
    public class StormcastEternalsFactory
    {
        public StormCastEternals Create(string version)
        {
            switch (version)
            {
                case "1.2018":
                default:
                    return CreateVersion12018();
            }
        }

        private StormCastEternals CreateVersion12018()
        {
            var faction = new StormCastEternals();

            faction.AllegianceAbilities = new Dictionary<AllegianceAbilityType, List<IAllegianceAbility>>
            {
                { AllegianceAbilityType.BattleTrait, GetBattleTraits() }
            };

            return faction;
        }

        public List<Warscroll> GetWarsrolls(string warscrollsPath)
        {
            var rawData = new FileAdapter().GetData(warscrollsPath);
            var result = new List<Warscroll>();
            result = JsonConvert.DeserializeObject<List<Warscroll>>(rawData);
            return result;
        }

        public  List<IAllegianceAbility> GetBattleTraits()
        {
            //TODO: to implement
            var rawData = new FileAdapter().GetData("resources/AllegianceAbilities/battle-traits-stormcast-12018.json");
            var battleTraits = new List<IAllegianceAbility>
            {

            };

            return battleTraits;
        }
    }
}
