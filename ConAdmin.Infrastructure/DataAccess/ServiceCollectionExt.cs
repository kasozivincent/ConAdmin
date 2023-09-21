using ConAdmin.Domain.Employees;
using ConAdmin.Domain.Projects;
using ConAdmin.Infrastructure.DataAccess.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace ConAdmin.Infrastructure.DataAccess;

public static class ServiceCollectionExt
{
    public static IServiceCollection RegisterDataAccess(this IServiceCollection services)
    {
        services.AddScoped<IProjectRepository, ProjectRepository>();
        services.AddScoped<IEmployeeRepository, EmployeeRepository>();
        return services;
    }
}