using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FontAwesome.Sharp;
using KretaBasicSchoolSystem.Desktop.ViewModels.Base;
using KretaBasicSchoolSystem.Desktop.ViewModels.ControlPanel;
using KretaBasicSchoolSystem.Desktop.ViewModels.SchoolCitizens;
using KretaBasicSchoolSystem.Desktop.ViewModels.SchoolClasses;
using KretaBasicSchoolSystem.Desktop.ViewModels.SchoolSubjects;

namespace KretaBasicSchoolSystem.Desktop.ViewModels
{
    public partial class MainViewModel : BaseViewModel
    {
        private ControlPanelViewModel _controlPanelViewModel;
        private SchoolCitizensViewModel _schoolCitizensViewModel;
        private SchoolClassesViewModel _schoolClassesViewModel;

        public MainViewModel()
        {
            _controlPanelViewModel = new ControlPanelViewModel();
            _schoolCitizensViewModel = new SchoolCitizensViewModel();
            _schoolClassesViewModel = new SchoolClassesViewModel();
        }

        public MainViewModel(
            ControlPanelViewModel controlPanelViewModel,  // golf ütő - dependency injection
            SchoolCitizensViewModel schoolCitizensViewModel,
            SchoolClassesViewModel schoolClassesViewModel
            )
        {
            _controlPanelViewModel = controlPanelViewModel;
            _schoolCitizensViewModel = schoolCitizensViewModel;
            _schoolClassesViewModel= schoolClassesViewModel;


            // CurrentChildView = _controlPanelViewModel; // amikor elindul a program legyen kiválasztott menüpont
            ShowDashbord();
        }

        [ObservableProperty]
        private string _caption = string.Empty;

        [ObservableProperty]
        private IconChar _icon = new IconChar();

        [ObservableProperty]
        private BaseViewModel _currentChildView;
        private BaseViewModel _schoolSubjectsViewModel;

        [RelayCommand]
        public void ShowDashbord()
        {
            Caption = "Vezérlőpult";
            Icon=IconChar.SolarPanel;
            CurrentChildView = _controlPanelViewModel;
        }

        [RelayCommand]
        public void ShowSchoolCitizens()
        {
            Caption = "Iskolapolgárok";
            Icon = IconChar.UserGroup;
            CurrentChildView = _schoolCitizensViewModel;
        }

        // SchoolClass menüpont meghívása
        [RelayCommand]
        public void ShowSchoolClasses()
        {
            Caption = "Osztályok";
            Icon = IconChar.ChalkboardUser;
            CurrentChildView = _schoolClassesViewModel;
        }
        [RelayCommand]
        public void ShowSubjectsCitizens()
        {
            Caption = "Tantárgyak";
            Icon = IconChar.UserGroup;
            CurrentChildView = _schoolSubjectsViewModel;
        }

    }
}
