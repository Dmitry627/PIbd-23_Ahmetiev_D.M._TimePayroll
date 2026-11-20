using Unity;
using TimePayroll.Entities.Enums;
using TimePayroll.Repositories;
using TimePayroll.Repositories.Implementations;
using TimePayroll.Services;

namespace TimePayroll;

// Запускает приложение и настраивает контейнер Unity
internal static class Program
{
    // Настраивает Windows Forms и запускает главную форму через Unity
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(CreateContainer().Resolve<MainForm>());
    }

    // Создает контейнер Unity и связывает интерфейсы репозиториев с реализациями
    private static IUnityContainer CreateContainer()
    {
        var container = new UnityContainer();
        container.RegisterType<IWorkEntryRepository, WorkEntryRepository>();
        container.RegisterType<IProjectRepository, ProjectRepository>();
        container.RegisterType<IPositionRepository, PositionRepository>();
        container.RegisterType<IEmployeeRepository, EmployeeRepository>();
        container.RegisterType<IEmployeeBonusRepository, EmployeeBonusRepository>();
        container.RegisterType<IPayrollRepository, PayrollRepository>();
        container.RegisterInstance(new PayrollRates(
            workCoefficients: new Dictionary<WorkType, decimal>(),
            bonusPercentages: new Dictionary<BonusType, decimal>()));
        return container;
    }
}
