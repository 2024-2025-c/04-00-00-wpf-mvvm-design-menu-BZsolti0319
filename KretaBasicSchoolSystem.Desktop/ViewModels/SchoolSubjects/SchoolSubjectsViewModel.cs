using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using KretaBasicSchoolSystem.Desktop.ViewModels.Base;
using KretaBasicSchoolSystem.Desktop.ViewModels.SchoolCitizens;

namespace KretaBasicSchoolSystem.Desktop.ViewModels.SchoolSubjects
{
    public partial class SchoolSubjectsViewModel : BaseViewModel
    {
        private SchoolSubjectsViewModel _schoolSubjectsViewModel;

        public SchoolSubjectsViewModel()
        {
            _schoolSubjectsViewModel = new SchoolSubjectsViewModel();
        }

        public SchoolSubjectsViewModel(SchoolSubjectsViewModel schoolSubjectsViewModel)
        {
            _schoolSubjectsViewModel = schoolSubjectsViewModel;

        }

        [ObservableProperty]
        private BaseViewModel _currentSchoolSubjectssChildView;

        public SchoolSubjectsViewModel CurrentSchoolSubjectsChildView { get; private set; }

        [RelayCommand]
        public void ShowStudentView()
        {
            CurrentSchoolSubjectsChildView = _schoolSubjectsViewModel;
        }

    }
}
