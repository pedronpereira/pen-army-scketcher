using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;

namespace PeNArmyScketcher.Desktop.WPF.ViewModel
{
    public class ForcesExplorerViewModel : ViewModelBase
    {
        public ForcesExplorerViewModel()
        {
        }

        public ForcesExplorerViewModel(IMessenger messenger) : base(messenger)
        {
        }

        public string Title { get; set; }
    }
}