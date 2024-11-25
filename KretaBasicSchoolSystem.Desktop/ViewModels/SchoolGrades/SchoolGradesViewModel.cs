using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using KretaBasicSchoolSystem.Desktop.ViewModels.Base;

namespace KretaBasicSchoolSystem.Desktop.ViewModels.SchoolGrades;

public partial class SchoolGradesViewModel : BaseViewModel
{
    private CurrentLessonViewModel _currentLessonViewModel;
    private TClassesViewModel _tClassesViewModel;
    private HYearViewModel _hYearViewModel;
    private EYearViewModel _eYearViewModel;

    public SchoolGradesViewModel()
    {
        _currentSchoolGradesChildViewModel = new CurrentLessonViewModel();
        _currentSchoolGradesChildViewModel = new TClassesViewModel();
        _currentSchoolGradesChildViewModel = new HYearViewModel();
        _currentSchoolGradesChildViewModel = new EYearViewModel();
        
        _currentLessonViewModel = new CurrentLessonViewModel();
        _tClassesViewModel = new TClassesViewModel();
        _hYearViewModel = new HYearViewModel();
        _eYearViewModel = new EYearViewModel();
    }

    public SchoolGradesViewModel(CurrentLessonViewModel currentLessonViewModel, TClassesViewModel tClassesViewModel,
        HYearViewModel hYearViewModel, EYearViewModel eYearViewModel)
    {
        _currentLessonViewModel = currentLessonViewModel;
        _tClassesViewModel = tClassesViewModel;
        _hYearViewModel = hYearViewModel;
        _eYearViewModel = eYearViewModel;
        
        _currentSchoolGradesChildViewModel = new CurrentLessonViewModel();
        _currentSchoolGradesChildViewModel = new TClassesViewModel();
        _currentSchoolGradesChildViewModel = new HYearViewModel();
        _currentSchoolGradesChildViewModel = new EYearViewModel();
    }
    
    [ObservableProperty]
    private BaseViewModel? _currentSchoolGradesChildViewModel;

    [RelayCommand]
    public void ShowCurrentLessonView()
    {
        CurrentSchoolGradesChildViewModel = _currentLessonViewModel;
    }
    
    [RelayCommand]
    public void ShowtTClassesView()
    {
        CurrentSchoolGradesChildViewModel = _tClassesViewModel;
    }
    
    [RelayCommand]
    public void ShowHYearView()
    {
        CurrentSchoolGradesChildViewModel = _hYearViewModel;
    }
    
    [RelayCommand]
    public void ShowEYearView()
    {
        CurrentSchoolGradesChildViewModel = _eYearViewModel;
    }
    
    
}