using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using KretaBasicSchoolSystem.Desktop.ViewModels.Base;

namespace KretaBasicSchoolSystem.Desktop.ViewModels.SchoolSubjects
{
    public partial class SchoolSubjectsViewModel : BaseViewModel
    {
        private SubjectViewModel _subjectViewModel;

        public SchoolSubjectsViewModel()
        {
            _currentSchoolSubjectChildView = new SubjectViewModel();
            _subjectViewModel = new SubjectViewModel();
        }

        public SchoolSubjectsViewModel(SubjectViewModel subjectViewModel)
        {
            _subjectViewModel = subjectViewModel;
            _currentSchoolSubjectChildView = new SubjectViewModel();
        }

        [ObservableProperty] 
        private BaseViewModel _currentSchoolSubjectChildView;

        [RelayCommand]
        public void ShowSubjectsView()
        {
            _currentSchoolSubjectChildView = _subjectViewModel;
        }
    }
}
