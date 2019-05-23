using System;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;

namespace PeNArmyScketcher.Desktop.WPF.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        private readonly NavigationMenuViewModel _navigationMenuViewModel;
        private readonly ForcesExplorerViewModel _forcesExplorerViewModel;
        private readonly ArmyViewViewModel _armyViewViewModel;

        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            _navigationMenuViewModel = new NavigationMenuViewModel();
            _forcesExplorerViewModel = new ForcesExplorerViewModel();
            _armyViewViewModel = new ArmyViewViewModel();

            //MessengerInstance.Register<NotificationMessageAction>("MainViewModel", message => ProcessMessage(message), true);

            if (IsInDesignMode)
            {
                Title = "Pen Army Scketcher (Design Mode)";
            }
            else
            {
                Title = "Pen Army Scketcher";
            }

            _forcesExplorerViewModel.Title = "The Forces Explorer";
            _armyViewViewModel.Title = "The Army View";
        }

        private void ProcessMessage(NotificationMessageAction message)
        {
            switch (message.Notification)
            {
                case "LoadArmy": //TODO: show dialog to load army
                    break;
                case "CreateNewArmy":
                    CreateNewArmy();
                    break;
                default:
                    break;
            }
        }

        private void CreateNewArmy()
        {
            throw new NotImplementedException();
        }

        public string Title { get; set; }

        public NavigationMenuViewModel NavigationMenuViewModel => _navigationMenuViewModel;
        public ForcesExplorerViewModel ForcesExplorerViewModel => _forcesExplorerViewModel;
        public ArmyViewViewModel ArmyViewViewModel => _armyViewViewModel;
    }
}