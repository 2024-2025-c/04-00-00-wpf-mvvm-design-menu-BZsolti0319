using KretaBasicSchoolSystem.Desktop.ViewModels;
using KretaBasicSchoolSystem.Desktop.ViewModels.ControlPanel;
using KretaBasicSchoolSystem.Desktop.ViewModels.Login;
using KretaBasicSchoolSystem.Desktop.ViewModels.SchoolCitizens;
using KretaBasicSchoolSystem.Desktop.ViewModels.SchoolClasses;
using KretaBasicSchoolSystem.Desktop.ViewModels.SchoolGrades;
using KretaBasicSchoolSystem.Desktop.ViewModels.SchoolSubjects;
using KretaBasicSchoolSystem.Desktop.Views;
using KretaBasicSchoolSystem.Desktop.Views.ControlPanel;
using KretaBasicSchoolSystem.Desktop.Views.Login;
using KretaBasicSchoolSystem.Desktop.Views.SchoolCitizens;
using KretaBasicSchoolSystem.Desktop.Views.SchoolClasses;
using KretaBasicSchoolSystem.Desktop.Views.SchoolGrades;
using KretaBasicSchoolSystem.Desktop.Views.SchoolSubjects;
using Microsoft.Extensions.DependencyInjection;

namespace KretaBasicSchoolSystem.Desktop.Extensions
{
    public static class ViewViewModelsExtensions
    {
        public static void ConfigureViewViewModels(this IServiceCollection services)
        {
            // MainView
            services.AddSingleton<MainViewModel>();
            services.AddSingleton<MainView>(s => new MainView()
            {
                DataContext = s.GetRequiredService<MainViewModel>()
            });

            // LoginView
            services.AddSingleton<LoginViewModel>();
            services.AddSingleton<LoginView>(s => new LoginView()
            {
                DataContext = s.GetRequiredService<LoginViewModel>()
            });

            // ControlPanel
            services.AddSingleton<ControlPanelViewModel>();
            services.AddSingleton<ControlPanelView>(s => new ControlPanelView()
            {
                DataContext = s.GetRequiredService<ControlPanelViewModel>()
            });
            // School Citizens
            services.AddSingleton<SchoolCitizensViewModel>();
            services.AddSingleton<SchoolCitizensView>(s => new SchoolCitizensView()
            {
                DataContext = s.GetRequiredService<SchoolCitizensViewModel>()
            });

            // Students
            // School Citizens
            services.AddSingleton<StudentViewModel>();
            services.AddSingleton<StudentView>(s => new StudentView()
            {
                DataContext = s.GetRequiredService<StudentViewModel>()
            });
            services.AddSingleton<ParentViewModel>();
            services.AddSingleton<ParentView>(s => new ParentView()
            {
                DataContext = s.GetRequiredService<ParentViewModel>()
            });
            services.AddSingleton<TeacherViewModel>();
            services.AddSingleton<TeacherView>(s => new TeacherView()
            {
                DataContext = s.GetRequiredService<TeacherViewModel>()
            });
            //SchoolClass
            services.AddSingleton<SchoolClassesViewModel>();
            services.AddSingleton<SchoolClassesView>(s => new SchoolClassesView()
            {
                DataContext = s.GetRequiredService<SchoolClassesViewModel>()
            });
            //tantárgyak? maybe idfk
            services.AddSingleton<SchoolSubjectsViewModel>();
            services.AddSingleton<SchoolSubjectsView>(s => new SchoolSubjectsView()
            {
                DataContext = s.GetRequiredService<SchoolSubjectsViewModel>()
            });
            //Osztályzatok
            services.AddSingleton<SchoolGradesViewModel>();
            services.AddSingleton<GradesView>(s => new GradesView()
            {
                DataContext = s.GetRequiredService<SchoolGradesViewModel>()
            });
            services.AddSingleton<CurrentLessonViewModel>();
            services.AddSingleton<CurrentLesson>(s => new CurrentLesson()
            {
                DataContext = s.GetRequiredService<CurrentLessonViewModel>()
            });
            services.AddSingleton<TClassesViewModel>();
            services.AddSingleton<TClassesView>(s => new TClassesView()
            {
                DataContext = s.GetRequiredService<TClassesViewModel>()
            });
            services.AddSingleton<HYearViewModel>();
            services.AddSingleton<HYearView>(s => new HYearView()
            {
                DataContext = s.GetRequiredService<HYearViewModel>()
            });
            services.AddSingleton<EYearViewModel>();
            services.AddSingleton<EYearView>(s => new EYearView()
            {
                DataContext = s.GetRequiredService<EYearViewModel>()
            });

        }
    }
}
