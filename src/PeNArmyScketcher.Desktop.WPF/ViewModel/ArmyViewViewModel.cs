using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;

namespace PeNArmyScketcher.Desktop.WPF.ViewModel
{
    public class ArmyViewViewModel : ViewModelBase
    {
        public ArmyViewViewModel()
        {
        }

        public ArmyViewViewModel(IMessenger messenger) : base(messenger)
        {
        }

        public string Title { get; set; }
    }
}