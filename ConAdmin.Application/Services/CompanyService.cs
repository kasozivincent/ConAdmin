using ConAdmin.Domain.Companies;
using ConAdmin.Infrastructure.DataAccess;

namespace ConAdmin.Application.Services;

public class CompanyService
{
    private readonly IUnitOfWork _uow;

    public CompanyService(IUnitOfWork uow)
        => this._uow = uow;

    public IEnumerable<Company> GetAllCompanies()
        => _uow.Companies.GetAll();

    public IEnumerable<Company> GetOwners()
        => GetAllCompanies();
    
    public void SaveCompany(Company company)
    {
       // CompanyService.repository[company.Key] = company;
      //  _uow.Companies.GetBy(company.Key) = company;
        _uow.OnComplete();
    }
}