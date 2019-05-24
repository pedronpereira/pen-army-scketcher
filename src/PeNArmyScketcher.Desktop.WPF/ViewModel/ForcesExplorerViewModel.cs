using System.Collections.ObjectModel;
using System.Linq;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;
using PeNArmyScketcher.AgeOfSigmar;
using PeNArmyScketcher.Desktop.WPF.Models;

namespace PeNArmyScketcher.Desktop.WPF.ViewModel
{
    public class ForcesExplorerViewModel : ViewModelBase
    {
        public ForcesExplorerViewModel()
        {
            InitializeWarscrolls();
        }

        public ForcesExplorerViewModel(IMessenger messenger) : base(messenger)
        {
            InitializeWarscrolls();
        }

        private void InitializeWarscrolls()
        {
            //TODO: Inject Factory, Initialize upon creating new army or loading existing army
            // move path of resources to a army settings/configuration.

            var faction = new FactionExplorerModel { Name = "Stormcast Eternals" };
            var factory = new StormcastEternalsFactory();
            var warscrolls = factory.GetWarsrolls("resources/warscrolls/stormcast-warscrolls-settings-20190517125430.json");

            var characters = new WarscrollExplorerModel
            {
                Role = "Characters",
                Warscrolls = new ObservableCollection<Warscroll>(warscrolls.Where(w => w.Role == UnitType.Leader || w.Role == UnitType.Unique))
            };
            var artillery = new WarscrollExplorerModel
            {
                Role = "Artillery",
                Warscrolls = new ObservableCollection<Warscroll>(warscrolls.Where(w => w.Role == UnitType.Artillery))
            };
            var units = new WarscrollExplorerModel
            {
                Role = "Units",
                Warscrolls = new ObservableCollection<Warscroll>(warscrolls.Where(w => w.Role == UnitType.Unit || w.Role == UnitType.Battleline))
            };
            faction.Warscrolls = new ObservableCollection<WarscrollExplorerModel>(new[] { characters, units, artillery });
            Factions = new ObservableCollection<FactionExplorerModel>(new[] { faction });
        }
        
        private ObservableCollection<FactionExplorerModel> _factions;

        public ObservableCollection<FactionExplorerModel> Factions
        {
            get { return _factions; }
            set
            {
                _factions = value;
                RaisePropertyChanged("Factions");
            }
        }

        public string Title { get; set; }
    }
}