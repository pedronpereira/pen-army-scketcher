using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;

namespace PeNArmyScketcher.Desktop.WPF.ViewModel
{
    public class NavigationMenuViewModel : ViewModelBase
    {
        public NavigationMenuViewModel()
        {
        }

        public NavigationMenuViewModel(IMessenger messenger) : base(messenger)
        {
        }
    }
}