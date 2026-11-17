using Unity;
using TimePayroll.Repositories;
using TimePayroll.Repositories.Implementations;

namespace TimePayroll;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        Application.Run(CreateContainer().Resolve<MainForm>());
    }

    private static IUnityContainer CreateContainer()
    {
        var container = new UnityContainer();
        container.RegisterType<IWorkEntryRepository, WorkEntryRepository>();
        container.RegisterType<IProjectRepository, ProjectRepository>();
        container.RegisterType<IPositionRepository, PositionRepository>();
        container.RegisterType<IEmployeeRepository, EmployeeRepository>();
        container.RegisterType<IEmployeeBonusRepository, EmployeeBonusRepository>();
        container.RegisterType<IPayrollRepository, PayrollRepository>();
        return container;
    }
}
