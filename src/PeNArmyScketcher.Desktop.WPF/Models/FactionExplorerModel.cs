using PeNArmyScketcher.AgeOfSigmar;
using System.Collections.ObjectModel;

namespace PeNArmyScketcher.Desktop.WPF.Models
{
    public class FactionExplorerModel
    {
        public string Name { get; set; }
        public ObservableCollection<WarscrollExplorerModel> Warscrolls { get; set; }
    }
}