using PeNArmyScketcher.AgeOfSigmar;
using System.Collections.ObjectModel;

namespace PeNArmyScketcher.Desktop.WPF.Models
{
    public class WarscrollExplorerModel
    {
        public string Role { get; set; }
        public ObservableCollection<Warscroll> Warscrolls { get; set;}
    }
}
