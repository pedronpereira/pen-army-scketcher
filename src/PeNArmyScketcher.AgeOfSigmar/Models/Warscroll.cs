namespace PeNArmyScketcher.AgeOfSigmar
{
    public class Warscroll
    {
        public string Name { get; set; }
        public int UnitSizeMin { get; set; }
        public int UnitSizeMax { get; set; }
        public int Points { get; set; }
        public UnitType Role { get; set; }
        public string Notes { get; set; }
    }
}