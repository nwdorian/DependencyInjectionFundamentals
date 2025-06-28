using Microsoft.Extensions.DependencyInjection;
using TeamPulse.Console.DataSource;
using TeamPulse.Console.Menus;
using TeamPulse.Console.Repositories;
using TeamPulse.Console.Services;
using TeamPulse.Console.Views;

namespace TeamPulse.Console.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddCustomServices(this IServiceCollection services)
    {
        services.AddTransient<IMainMenu, MainMenu>();
        services.AddTransient<IEmployeeView, EmployeeView>();
        services.AddTransient<IEmployeeService, EmployeeService>();
        services.AddTransient<IEmployeeRepository, EmployeeRepository>();
        services.AddTransient<IEmployeeData, EmployeeData>();

        return services;
    }
}
