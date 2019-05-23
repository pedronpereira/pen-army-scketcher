using System;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;

namespace PeNArmyScketcher.Desktop.WPF.ViewModel
{
    public class NavigationMenuViewModel : ViewModelBase
    {
        private ObservableCollection<Button> _navigationButtons;
        private Button _newArmyButton;
        private Button _loadArmyButton;

        public ObservableCollection<Button> NavigationButtons
        {
            get => _navigationButtons; set
            {
                _navigationButtons = value;
                RaisePropertyChanged("NavigationButtons");
            }
        }

        public NavigationMenuViewModel()
        {
            InitializeNavigationButtons();
        }


        public NavigationMenuViewModel(IMessenger messenger) : base(messenger)
        {
            InitializeNavigationButtons();
        }

        private void InitializeNavigationButtons()
        {
            _newArmyButton = new Button { Content = "New Army", Command = new RelayCommand(() => NewArmyCommand()) };
            _loadArmyButton = new Button { Content = "Load Army", Command = new RelayCommand(() => LoadArmyCommand()) };

            var mainMenuButtons = new ObservableCollection<Button>
            {
                _newArmyButton,
                _loadArmyButton
            };

            NavigationButtons = mainMenuButtons;
        }

        private void LoadArmyCommand()
        {
            MessengerInstance.Send(new NotificationMessageAction("LoadArmy", () => LoadArmyNavigationButtons()));
        }

        private void NewArmyCommand()
        {
            MessengerInstance.Send(new NotificationMessageAction("CreateNewArmy", () => LoadArmyNavigationButtons()));
        }

        private void LoadArmyNavigationButtons()
        {
            throw new NotImplementedException();
        }
    }
}