using ConAdmin.Domain.Companies;
using ConAdmin.Domain.Contacts;
using ConAdmin.Domain.Employees;
using ConAdmin.Domain.Projects;
using ConAdmin.Infrastructure.DataAccess;
using ConAdmin.Infrastructure.DataAccess.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace ConAdmin.Infrastructure;
public static class ServiceCollectionExt
{
    public static IServiceCollection RegisterDataAccess(this IServiceCollection services)
    {
        services.AddScoped<IProjectRepository, ProjectRepository>();
        services.AddScoped<IEmployeeRepository, EmployeeRepository>();
        services.AddScoped<ICompanyRepository, CompanyRepository>();
        services.AddScoped<IContactRepository, ContactRepository>();
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        return services;
    }
}